namespace Winov
{
    partial class Form1
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
            btnSalvar = new Button();
            btnCancel = new Button();
            radioPRD = new RadioButton();
            radioHML = new RadioButton();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtWS = new TextBox();
            txtAPI = new TextBox();
            txtClient = new TextBox();
            dt = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtPort = new TextBox();
            txtUser = new TextBox();
            txtPwd = new TextBox();
            txtDb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtHost = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnTest = new Button();
            Client = new DataGridViewTextBoxColumn();
            WS = new DataGridViewTextBoxColumn();
            API = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(23, 199);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(149, 199);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // radioPRD
            // 
            radioPRD.AutoSize = true;
            radioPRD.Location = new Point(23, 153);
            radioPRD.Name = "radioPRD";
            radioPRD.Size = new Size(126, 24);
            radioPRD.TabIndex = 2;
            radioPRD.TabStop = true;
            radioPRD.Text = "Homologação";
            radioPRD.UseVisualStyleBackColor = true;
            // 
            // radioHML
            // 
            radioHML.AutoSize = true;
            radioHML.Location = new Point(169, 153);
            radioHML.Name = "radioHML";
            radioHML.Size = new Size(93, 24);
            radioHML.TabIndex = 3;
            radioHML.TabStop = true;
            radioHML.Text = "Produção";
            radioHML.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(7, 17);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtWS);
            splitContainer1.Panel1.Controls.Add(txtAPI);
            splitContainer1.Panel1.Controls.Add(txtClient);
            splitContainer1.Panel1.Controls.Add(radioPRD);
            splitContainer1.Panel1.Controls.Add(radioHML);
            splitContainer1.Panel1.Controls.Add(btnSalvar);
            splitContainer1.Panel1.Controls.Add(btnCancel);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dt);
            splitContainer1.Size = new Size(1048, 454);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 68);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Porta WS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Porta API";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // txtWS
            // 
            txtWS.Location = new Point(98, 61);
            txtWS.Name = "txtWS";
            txtWS.Size = new Size(125, 27);
            txtWS.TabIndex = 6;
            txtWS.TextChanged += textBox3_TextChanged;
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(98, 104);
            txtAPI.Name = "txtAPI";
            txtAPI.Size = new Size(125, 27);
            txtAPI.TabIndex = 5;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(82, 28);
            txtClient.Name = "txtClient";
            txtClient.Size = new Size(180, 27);
            txtClient.TabIndex = 4;
            // 
            // dt
            // 
            dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt.Columns.AddRange(new DataGridViewColumn[] { Client, WS, API, type });
            dt.Location = new Point(31, 31);
            dt.Name = "dt";
            dt.RowHeadersWidth = 51;
            dt.Size = new Size(553, 402);
            dt.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1080, 514);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1072, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtPort);
            tabPage2.Controls.Add(txtUser);
            tabPage2.Controls.Add(txtPwd);
            tabPage2.Controls.Add(txtDb);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtHost);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(btnTest);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1072, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configuração";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(359, 111);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 27);
            txtPort.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(359, 153);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 27);
            txtUser.TabIndex = 10;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(359, 194);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(175, 27);
            txtPwd.TabIndex = 9;
            // 
            // txtDb
            // 
            txtDb.Location = new Point(359, 227);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(175, 27);
            txtDb.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(276, 234);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Database";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 201);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 160);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 118);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "Port";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(359, 70);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(175, 27);
            txtHost.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 77);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 2;
            label4.Text = "Host";
            label4.Click += label4_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(494, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(359, 296);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 0;
            btnTest.Text = "Testar";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Client
            // 
            Client.HeaderText = "Cliente";
            Client.MinimumWidth = 6;
            Client.Name = "Client";
            Client.Width = 125;
            // 
            // WS
            // 
            WS.HeaderText = "WS";
            WS.MinimumWidth = 6;
            WS.Name = "WS";
            WS.Width = 125;
            // 
            // API
            // 
            API.HeaderText = "API";
            API.MinimumWidth = 6;
            API.Name = "API";
            API.Width = 125;
            // 
            // type
            // 
            type.HeaderText = "Tipo";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 513);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dt).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancel;
        private RadioButton radioPRD;
        private RadioButton radioHML;
        private SplitContainer splitContainer1;
        private DataGridView dt;
        private Label label1;
        private TextBox txtWS;
        private TextBox txtAPI;
        private TextBox txtClient;
        private Label label3;
        private Label label2;
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
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn WS;
        private DataGridViewTextBoxColumn API;
        private DataGridViewTextBoxColumn type;
    }
}
