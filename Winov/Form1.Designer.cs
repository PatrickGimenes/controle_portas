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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSalvar = new Button();
            btnCancel = new Button();
            radioPRD = new RadioButton();
            radioHML = new RadioButton();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            dt = new DataGridView();
            Client = new DataGridViewTextBoxColumn();
            WS = new DataGridViewTextBoxColumn();
            API = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtWS = new TextBox();
            txtAPI = new TextBox();
            txtClient = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            panel2 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(63, 228);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(201, 228);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // radioPRD
            // 
            radioPRD.AutoSize = true;
            radioPRD.Location = new Point(31, 165);
            radioPRD.Name = "radioPRD";
            radioPRD.Size = new Size(126, 24);
            radioPRD.TabIndex = 4;
            radioPRD.TabStop = true;
            radioPRD.Text = "Homologação";
            radioPRD.UseVisualStyleBackColor = true;
            // 
            // radioHML
            // 
            radioHML.AutoSize = true;
            radioHML.Location = new Point(202, 165);
            radioHML.Name = "radioHML";
            radioHML.Size = new Size(93, 24);
            radioHML.TabIndex = 5;
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
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(1048, 454);
            splitContainer1.SplitterDistance = 348;
            splitContainer1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(dt);
            panel3.Location = new Point(32, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 454);
            panel3.TabIndex = 1;
            // 
            // dt
            // 
            dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt.Columns.AddRange(new DataGridViewColumn[] { Client, WS, API, type });
            dt.Location = new Point(39, 33);
            dt.Name = "dt";
            dt.RowHeadersWidth = 51;
            dt.Size = new Size(558, 402);
            dt.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 70);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Porta WS";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 113);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Porta API";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // txtWS
            // 
            txtWS.Location = new Point(115, 75);
            txtWS.Name = "txtWS";
            txtWS.PlaceholderText = "WS";
            txtWS.Size = new Size(180, 27);
            txtWS.TabIndex = 2;
            txtWS.TextChanged += textBox3_TextChanged;
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(115, 117);
            txtAPI.Name = "txtAPI";
            txtAPI.PlaceholderText = "API";
            txtAPI.Size = new Size(180, 27);
            txtAPI.TabIndex = 3;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(115, 33);
            txtClient.Name = "txtClient";
            txtClient.PlaceholderText = "Cliente";
            txtClient.Size = new Size(180, 27);
            txtClient.TabIndex = 1;
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
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1072, 481);
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
            panel1.Controls.Add(radioHML);
            panel1.Controls.Add(txtAPI);
            panel1.Controls.Add(radioPRD);
            panel1.Controls.Add(txtClient);
            panel1.Location = new Point(0, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 454);
            panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1072, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configuração";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
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
            panel2.Location = new Point(303, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 395);
            panel2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 60);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 2;
            label4.Text = "Host";
            label4.Click += label4_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(121, 101);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(175, 27);
            txtPort.TabIndex = 1;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(102, 282);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 5;
            btnTest.Text = "Testar";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(121, 143);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(175, 27);
            txtUser.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(202, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(121, 184);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(175, 27);
            txtPwd.TabIndex = 3;
            txtPwd.TextChanged += txtPwd_TextChanged;
            // 
            // txtHost
            // 
            txtHost.Location = new Point(121, 60);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(175, 27);
            txtHost.TabIndex = 0;
            txtHost.TextChanged += txtHost_TextChanged;
            // 
            // txtDb
            // 
            txtDb.Location = new Point(121, 220);
            txtDb.Name = "txtDb";
            txtDb.Size = new Size(175, 27);
            txtDb.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 104);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "Port";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 223);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 7;
            label8.Text = "Database";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 146);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 187);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 513);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de portas - Winov";
            Load += Form1_Load;
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dt).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
