using System.Data;
using System.IO;
using Winov.Helpers;

namespace Winov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtClient.Clear();
            txtAPI.Clear();
            txtWS.Clear();

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
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)

        {
            string path = Path.Combine(Application.StartupPath, "config.ini");
            try
            {
                var iniReader = new IniReader(path);
                string connectionString = iniReader.GetConnectionString();

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

            //string connString = "Host=" + txtHost.Text + ";Port=" + txtPort.Text + ";Username=" + txtUser.Text + ";Password=" + txtPwd.Text + ";Database=" + txtDb.Text + ";";

        }

        private void clearTxt()
        {
            txtHost.Clear();
            txtPort.Clear();
            txtUser.Clear();
            txtPwd.Clear();
            txtDb.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string type = "";

            if (radioHML.Checked)
                type = radioHML.Text;
            if (radioPRD.Checked)
                type = radioPRD.Text;

            if (txtClient.Text != "" && txtWS.Text != "" && txtAPI.Text != "" && type != "")
            {
                using (StreamWriter writer = new StreamWriter("dados.csv", true))
                {
                    writer.Write(txtClient.Text + "," + txtWS.Text + "," + txtAPI.Text + "," + type + "\n");
                }
                txtAPI.Clear();
                txtClient.Clear();
                txtWS.Clear();
                radioHML.Checked = false;
                radioPRD.Checked = false;

                string path = "dados.csv";
                loadTable(path);
            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loadTable(string path)
        {
            dt.Rows.Clear();

            var linhas = File.ReadAllLines(path);


            for (int i = 0; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',');
                dt.Rows.Add(dados);
            }
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
