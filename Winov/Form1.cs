using System.Data;

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
            using (StreamWriter writer = new StreamWriter("config.ini"))
            {
                writer.WriteLine("[Conex�o]");
                writer.WriteLine("HOST = " + txtHost.Text);
                writer.WriteLine("PORT = " + txtPort.Text);
                writer.WriteLine("USER = " + txtUser.Text);
                writer.WriteLine("PASSWORD = " + txtPwd.Text);
                writer.WriteLine("DATABASE = " + txtDb.Text);
            }

            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxt();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

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

            if(radioHML.Checked)
                type = radioHML.Text;
            if(radioPRD.Checked)
                type = radioPRD.Text;

            using (StreamWriter writer = new StreamWriter("dados.csv", true))        
            {
                writer.Write(txtClient.Text + "," + txtWS.Text + ","+ txtAPI.Text+","+type+"\n");
            }
            txtAPI.Clear();
            txtClient.Clear();
            txtWS.Clear();
            radioHML.Checked = false;
            radioPRD.Checked = false;

            string path = "dados.csv";
            loadTable(path);
        }

        private void loadTable(string path) {
            dt.Rows.Clear();

            var linhas = File.ReadAllLines(path);
 

            for (int i = 0;  i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(',');
                dt.Rows.Add(dados);
            }
        }
    }
}
