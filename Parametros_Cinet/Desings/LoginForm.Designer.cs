namespace Parametros_Cinet.Desings
{
    partial class LoginForm
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
            textBoxUser = new TextBox();
            btnConnect = new Button();
            textBoxPass = new TextBox();
            textBoxIp = new TextBox();
            textBoxPort = new TextBox();
            comboBoxDataBase = new ComboBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(22, 94);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(108, 23);
            textBoxUser.TabIndex = 1;
            textBoxUser.Text = "10";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(22, 245);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(82, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "CONECTAR";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(22, 138);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(108, 23);
            textBoxPass.TabIndex = 4;
            textBoxPass.Text = "cinettorcel";
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // textBoxIp
            // 
            textBoxIp.Location = new Point(22, 187);
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(108, 23);
            textBoxIp.TabIndex = 7;
            textBoxIp.Text = "26.98.235.46";
            textBoxIp.TextChanged += textBoxIp_TextChanged;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(22, 216);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(108, 23);
            textBoxPort.TabIndex = 8;
            textBoxPort.Text = "1433";
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(22, 308);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(97, 23);
            comboBoxDataBase.TabIndex = 10;
            comboBoxDataBase.SelectedIndexChanged += comboBoxDataBase_SelectedIndexChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(125, 307);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 12;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 285);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 13;
            label2.Text = "BASE DE DATOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 164);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 14;
            label3.Text = "IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 120);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 15;
            label4.Text = "CONTRASEÑA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(49, 117, 162);
            pictureBox1.Location = new Point(-6, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 56);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(49, 117, 162);
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 32);
            label5.TabIndex = 17;
            label5.Text = "CINET\r\n";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(231, 348);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(comboBoxDataBase);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIp);
            Controls.Add(btnConnect);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "CINET";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxUser;
        private Button btnConnect;
        private TextBox textBoxPass;
        private TextBox textBoxIp;
        private TextBox textBoxPort;
        private Button btnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        public ComboBox comboBoxDataBase;
    }
}