using System.ComponentModel;

namespace Winov
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            table = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnSalvar = new Button();
            txtWS = new TextBox();
            radioPRD = new RadioButton();
            txtAPI = new TextBox();
            radioHML = new RadioButton();
            txtClient = new TextBox();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            lblInfo = new Label();
            btnSalvarPorta = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtSalto = new TextBox();
            txtIncial = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            label4 = new Label();
            txtPort = new TextBox();
            btnTest = new Button();
            txtUser = new TextBox();
            btnSave = new Button();
            txtPwd = new TextBox();
            txtHost = new TextBox();
            txtDb = new TextBox();
            label5 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuEditar = new ToolStripMenuItem();
            menuExcluir = new ToolStripMenuItem();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)table).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(9, 21);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1310, 568);
            splitContainer1.SplitterDistance = 435;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(table);
            panel3.Location = new Point(-9, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(822, 568);
            panel3.TabIndex = 1;
            // 
            // table
            // 
            table.BackgroundColor = SystemColors.ControlLightLight;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(49, 41);
            table.Margin = new Padding(4);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(757, 502);
            table.TabIndex = 0;
            table.MouseDown += table_MouseDown;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 642);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1342, 604);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(txtWS);
            panel1.Controls.Add(radioPRD);
            panel1.Controls.Add(txtAPI);
            panel1.Controls.Add(radioHML);
            panel1.Controls.Add(txtClient);
            panel1.Location = new Point(0, 21);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 568);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 9;
            label3.Text = "Porta WS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 8;
            label2.Text = "Porta API";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 285);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(79, 285);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(118, 36);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtWS
            // 
            txtWS.Location = new Point(144, 94);
            txtWS.Margin = new Padding(4);
            txtWS.Name = "txtWS";
            txtWS.PlaceholderText = "WS";
            txtWS.Size = new Size(224, 31);
            txtWS.TabIndex = 2;
            // 
            // radioPRD
            // 
            radioPRD.AutoSize = true;
            radioPRD.Location = new Point(252, 206);
            radioPRD.Margin = new Padding(4);
            radioPRD.Name = "radioPRD";
            radioPRD.Size = new Size(113, 29);
            radioPRD.TabIndex = 5;
            radioPRD.TabStop = true;
            radioPRD.Text = "Produção";
            radioPRD.UseVisualStyleBackColor = true;
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(144, 146);
            txtAPI.Margin = new Padding(4);
            txtAPI.Name = "txtAPI";
            txtAPI.PlaceholderText = "API";
            txtAPI.Size = new Size(224, 31);
            txtAPI.TabIndex = 3;
            // 
            // radioHML
            // 
            radioHML.AutoSize = true;
            radioHML.Location = new Point(39, 206);
            radioHML.Margin = new Padding(4);
            radioHML.Name = "radioHML";
            radioHML.Size = new Size(151, 29);
            radioHML.TabIndex = 4;
            radioHML.TabStop = true;
            radioHML.Text = "Homologação";
            radioHML.UseVisualStyleBackColor = true;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(144, 41);
            txtClient.Margin = new Padding(4);
            txtClient.Name = "txtClient";
            txtClient.PlaceholderText = "Cliente";
            txtClient.Size = new Size(224, 31);
            txtClient.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1342, 604);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configuração";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblInfo);
            panel4.Controls.Add(btnSalvarPorta);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(txtSalto);
            panel4.Controls.Add(txtIncial);
            panel4.Location = new Point(674, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(435, 495);
            panel4.TabIndex = 13;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(123, 288);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(165, 100);
            lblInfo.TabIndex = 13;
            lblInfo.Text = "Configuração atual:\r\n\r\nPorta inicial: 9030\r\nSalto: 5";
            // 
            // btnSalvarPorta
            // 
            btnSalvarPorta.Location = new Point(148, 230);
            btnSalvarPorta.Name = "btnSalvarPorta";
            btnSalvarPorta.Size = new Size(112, 34);
            btnSalvarPorta.TabIndex = 12;
            btnSalvarPorta.Text = "Salvar";
            btnSalvarPorta.UseVisualStyleBackColor = true;
            btnSalvarPorta.Click += btnSalvarPorta_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(75, 167);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(52, 25);
            label12.TabIndex = 11;
            label12.Text = "Salto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 109);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(97, 25);
            label11.TabIndex = 10;
            label11.Text = "Porta incial";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(75, 11);
            label10.Name = "label10";
            label10.Size = new Size(321, 45);
            label10.TabIndex = 9;
            label10.Text = "Sugestão de portas";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSalto
            // 
            txtSalto.Location = new Point(138, 161);
            txtSalto.Name = "txtSalto";
            txtSalto.Size = new Size(150, 31);
            txtSalto.TabIndex = 2;
            // 
            // txtIncial
            // 
            txtIncial.Location = new Point(137, 109);
            txtIncial.Name = "txtIncial";
            txtIncial.Size = new Size(150, 31);
            txtIncial.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPort);
            panel2.Controls.Add(btnTest);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtPwd);
            panel2.Controls.Add(txtHost);
            panel2.Controls.Add(txtDb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(95, 31);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 495);
            panel2.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(117, 11);
            label9.Name = "label9";
            label9.Size = new Size(268, 45);
            label9.TabIndex = 8;
            label9.Text = "Banco de dados";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 2;
            label4.Text = "Host";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(151, 126);
            txtPort.Margin = new Padding(4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(218, 31);
            txtPort.TabIndex = 1;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(128, 352);
            btnTest.Margin = new Padding(4);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(118, 36);
            btnTest.TabIndex = 5;
            btnTest.Text = "Testar";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(151, 230);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(218, 31);
            txtUser.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(252, 352);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 36);
            btnSave.TabIndex = 6;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(151, 281);
            txtPwd.Margin = new Padding(4);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(218, 31);
            txtPwd.TabIndex = 4;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(151, 75);
            txtHost.Margin = new Padding(4);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(218, 31);
            txtHost.TabIndex = 0;
            // 
            // txtDb
            // 
            txtDb.Location = new Point(151, 179);
            txtDb.Margin = new Padding(4);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(218, 31);
            txtDb.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 4;
            label5.Text = "Port";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 183);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 7;
            label8.Text = "Database";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 233);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 285);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 25);
            label7.TabIndex = 6;
            label7.Text = "Password";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuEditar, menuExcluir });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 68);
            // 
            // menuEditar
            // 
            menuEditar.Name = "menuEditar";
            menuEditar.Size = new Size(133, 32);
            menuEditar.Text = "Editar";
            menuEditar.Click += menuEditar_Click;
            // 
            // menuExcluir
            // 
            menuExcluir.Name = "menuExcluir";
            menuExcluir.Size = new Size(133, 32);
            menuExcluir.Text = "Excluir";
            menuExcluir.Click += menuExcluir_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 641);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de portas - Winov";
            Load += Form1_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((ISupportInitialize)table).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView table;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtHost;
        private Label label4;
        private Button btnSave;
        private Button btnTest;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox txtPort;
        private TextBox txtUser;
        private TextBox txtPwd;
        private TextBox txtDb;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Button btnSalvar;
        private TextBox txtWS;
        private RadioButton radioPRD;
        private TextBox txtAPI;
        private RadioButton radioHML;
        private TextBox txtClient;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuEditar;
        private ToolStripMenuItem menuExcluir;
        private Panel panel4;
        private Label label10;
        private TextBox txtSalto;
        private TextBox txtIncial;
        private Label label9;
        private Button btnSalvarPorta;
        private Label label12;
        private Label label11;
        private Label lblInfo;
    }
}
