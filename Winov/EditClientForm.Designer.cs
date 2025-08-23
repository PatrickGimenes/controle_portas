namespace Winov
{
    partial class EditClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnAtualizar = new Button();
            txtWS = new TextBox();
            radioPRD = new RadioButton();
            txtAPI = new TextBox();
            radioHML = new RadioButton();
            txtClient = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 19;
            label3.Text = "Porta WS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 16;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 18;
            label2.Text = "Porta API";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(304, 295);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(132, 295);
            btnAtualizar.Margin = new Padding(4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(118, 36);
            btnAtualizar.TabIndex = 15;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtWS
            // 
            txtWS.Location = new Point(197, 104);
            txtWS.Margin = new Padding(4);
            txtWS.Name = "txtWS";
            txtWS.PlaceholderText = "WS";
            txtWS.Size = new Size(224, 31);
            txtWS.TabIndex = 11;
            // 
            // radioPRD
            // 
            radioPRD.AutoSize = true;
            radioPRD.Location = new Point(305, 216);
            radioPRD.Margin = new Padding(4);
            radioPRD.Name = "radioPRD";
            radioPRD.Size = new Size(113, 29);
            radioPRD.TabIndex = 14;
            radioPRD.TabStop = true;
            radioPRD.Text = "Produção";
            radioPRD.UseVisualStyleBackColor = true;
            // 
            // txtAPI
            // 
            txtAPI.Location = new Point(197, 156);
            txtAPI.Margin = new Padding(4);
            txtAPI.Name = "txtAPI";
            txtAPI.PlaceholderText = "API";
            txtAPI.Size = new Size(224, 31);
            txtAPI.TabIndex = 12;
            // 
            // radioHML
            // 
            radioHML.AutoSize = true;
            radioHML.Location = new Point(92, 216);
            radioHML.Margin = new Padding(4);
            radioHML.Name = "radioHML";
            radioHML.Size = new Size(151, 29);
            radioHML.TabIndex = 13;
            radioHML.TabStop = true;
            radioHML.Text = "Homologação";
            radioHML.UseVisualStyleBackColor = true;
            // 
            // txtClient
            // 
            txtClient.Location = new Point(197, 51);
            txtClient.Margin = new Padding(4);
            txtClient.Name = "txtClient";
            txtClient.PlaceholderText = "Cliente";
            txtClient.Size = new Size(224, 31);
            txtClient.TabIndex = 10;
            // 
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 363);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAtualizar);
            Controls.Add(txtWS);
            Controls.Add(radioPRD);
            Controls.Add(txtAPI);
            Controls.Add(radioHML);
            Controls.Add(txtClient);
            Name = "EditClientForm";
            Text = "EditClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Button btnAtualizar;
        private TextBox txtWS;
        private RadioButton radioPRD;
        private TextBox txtAPI;
        private RadioButton radioHML;
        private TextBox txtClient;
    }
}