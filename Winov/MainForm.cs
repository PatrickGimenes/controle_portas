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

            //Sugere novas portas
            FillPortSuggestions();

            UpdateLabe();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTxt();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHost.Text != "" && txtPort.Text != "" && txtPwd.Text != "" && txtUser.Text != "" && txtDb.Text != "")
            {

                var iniWriter = new IniConfigWriter(path);
                iniWriter.SaveConnectionConfig(txtHost.Text, txtPort.Text, txtUser.Text, txtPwd.Text, txtDb.Text);
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTxt();


                var iniReader = new IniReader(path);
                connectionString = iniReader.GetConnectionString();
                PostgresHelper.EnsureTableExists(connectionString);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Erro na conexão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sucesso na conexão", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void clearTxt()
        {
            txtHost.Clear();
            txtPort.Clear();
            txtUser.Clear();
            txtPwd.Clear();
            txtDb.Clear();

            txtIncial.Clear();
            txtSalto.Clear();


            txtAPI.Clear();
            txtClient.Clear();
            txtWS.Clear();
            radioPRD.Checked = false;
            radioHML.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int API;
            int WS;
            string type = radioPRD.Checked ? "Produção" : "Homologação";

            if (!string.IsNullOrEmpty(txtClient.Text) &&
                           !string.IsNullOrEmpty(txtWS.Text) &&
                           !string.IsNullOrEmpty(txtAPI.Text) &&
                           !string.IsNullOrEmpty(type))
            {

                if (!int.TryParse(txtAPI.Text, out API) || !int.TryParse(txtWS.Text, out WS))
                {
                    MessageBox.Show("A porta deve ser um inteiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PostgresHelper.InsertClient(connectionString, txtClient.Text, WS, API, type);
                LoadTableFromDatabase();

                clearTxt();
                FillPortSuggestions();
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var result = MessageBox.Show("Deseja realmente excluir esta linha?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void FillPortSuggestions()
        {
            int ws, api;
            PortHelper.SuggestPorts(connectionString, "config_port.ini", out ws, out api);
            txtWS.Text = ws.ToString();
            txtAPI.Text = api.ToString();
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

        private void btnSalvarPorta_Click(object sender, EventArgs e)
        {
            if (txtIncial.Text != "" && txtSalto.Text != "")
            {
            
                if (!int.TryParse(txtIncial.Text, out int inicial) || !int.TryParse(txtSalto.Text, out int salto))
                {
                    MessageBox.Show("A porta deve ser um inteiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var iniWriter = new IniConfigWriter(path);
                iniWriter.SavePortConfig(inicial, salto);
                
                clearTxt();

                UpdateLabe();
                


                var iniReader = new IniReader(path);
                connectionString = iniReader.GetConnectionString();
                PostgresHelper.EnsureTableExists(connectionString);
                FillPortSuggestions();
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabe()
        {

            try
            {
                var iniReader = new IniReader("config_port.ini");
                var (inicial, salto) = iniReader.GetPortConfig();
                lblInfo.Text = $"Configuração atual:\r\n\r\nPorta inicial: {inicial}\r\nSalto: {salto}";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Configuração de portas não encontrada ou inválida.";
                Console.WriteLine(ex.Message); // opcional, só para debug
            }
            
        }
    }
}
