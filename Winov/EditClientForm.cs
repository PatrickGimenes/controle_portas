using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winov.Helpers;

namespace Winov
{
    public partial class EditClientForm : Form
    {
        private string connectionString;
        private int clientId;
        
        public EditClientForm(int id, string client, string type, string ws, string api)
        {
            InitializeComponent();

            string path = Path.Combine(Application.StartupPath, "config.ini");
            var iniReader = new IniReader(path);
            connectionString = iniReader.GetConnectionString();

            clientId = id;
            txtClient.Text = client;

            if (type == "Homologação")
                radioHML.Checked = true;
            else
                radioPRD.Checked = true;

            txtWS.Text = ws;
            txtAPI.Text = api;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int API, WS;
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
                PostgresHelper.UpdateClient(connectionString, clientId, txtClient.Text, WS, API, type);

            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
