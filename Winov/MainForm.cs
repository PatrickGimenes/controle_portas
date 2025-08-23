using Npgsql;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Winov.Helpers;

namespace Winov
{
    public partial class MainForm : Form
    {
        string path = Path.Combine(Application.StartupPath, "config.ini");
        private string connectionString;
        private int API;
        private int WS;
        public MainForm()
        {
            InitializeComponent();
            // Melhorar visual do DataGridView
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.ReadOnly = true;
            table.RowHeadersVisible = false;
            table.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var iniReader = new IniReader(path);
            connectionString = iniReader.GetConnectionString();

            // Garante que a tabela exista
            PostgresHelper.EnsureTableExists(connectionString);

            // Carrega os dados no DataGridView
            LoadTableFromDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTxt();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "config.ini");
            if (txtHost.Text != "" && txtPort.Text != "" && txtPwd.Text != "" && txtUser.Text != "" && txtDb.Text != "")
            {

                var iniWriter = new IniConfigWriter(path);
                iniWriter.SaveConfig(txtHost, txtPort, txtUser, txtPwd, txtDb);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTxt();
                var iniReader = new IniReader(path);
                connectionString = iniReader.GetConnectionString();
                PostgresHelper.EnsureTableExists(connectionString);
            }
            else
            {
                MessageBox.Show("� necess�rio preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)

        {
            string connectionString = "Host=" + txtHost.Text.Trim() +
                    ";Port=" + txtPort.Text.Trim() +
                    ";Username=" + txtUser.Text.Trim() +
                    ";Password=" + txtPwd.Text.Trim() +
                    ";Database=" + txtDb.Text.Trim();
            try
            {
         

                if (!PostgresHelper.TestConnection(connectionString))
                {
                    MessageBox.Show("Erro na conex�o", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sucesso na conex�o", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conex�o: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void clearTxt()
        {
            txtHost.Clear();
            txtPort.Clear();
            txtUser.Clear();
            txtPwd.Clear();
            txtDb.Clear();


            txtAPI.Clear();
            txtClient.Clear();
            txtWS.Clear();
            radioPRD.Checked = false;
            radioHML.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string type = radioPRD.Checked ? "Produ��o": "Homologa��o";

            if (!string.IsNullOrEmpty(txtClient.Text) &&
                           !string.IsNullOrEmpty(txtWS.Text) &&
                           !string.IsNullOrEmpty(txtAPI.Text) &&
                           !string.IsNullOrEmpty(type))
            {
                
                if (!int.TryParse(txtWS.Text, out API) || !int.TryParse(txtWS.Text, out WS))
                {
                    MessageBox.Show("A porta deve ser um inteiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PostgresHelper.InsertClient(connectionString, txtClient.Text, WS, API, type);
                LoadTableFromDatabase();

                clearTxt();
            }
            else
            {
                MessageBox.Show("� necess�rio preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadTableFromDatabase()
        {
            PostgresHelper.SelectAll(connectionString, table);
        }

        private void menuExcluir_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Deseja realmente excluir esta linha?", "Confirmar exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var row = table.SelectedRows[0];
                    if (row.Cells["id"].Value != null)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        PostgresHelper.DeleteClient(connectionString, id);
                    }

                    // Remover do DataGridView
                    table.Rows.Remove(row);
                }
            }

        }

        private void table_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = table.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    table.ClearSelection();
                    table.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(table, e.Location);
                }
            }
        }

        private void menuEditar_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                var row = table.SelectedRows[0];

                // Pegar valores atuais da linha
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string client = row.Cells["nome"].Value?.ToString();
                string type = row.Cells["ambiente"].Value?.ToString();
                string wsText = row.Cells["ws"].Value?.ToString();
                string apiText = row.Cells["api"].Value?.ToString();

                // Abrir modal e passar valores
                using (var editForm = new EditClientForm(id, client, type, wsText, apiText))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadTableFromDatabase();
                    }
                }
            }
        }
    }
}
