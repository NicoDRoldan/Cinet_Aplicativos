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
            label1 = new Label();
            textBoxUser = new TextBox();
            btnConnect = new Button();
            textBoxPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxIp = new TextBox();
            textBoxPort = new TextBox();
            label4 = new Label();
            comboBoxDataBase = new ComboBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 16);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(124, 27);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(100, 23);
            textBoxUser.TabIndex = 1;
            textBoxUser.Text = "10";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(123, 174);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(82, 23);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "CONECTAR";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(124, 71);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(100, 23);
            textBoxPass.TabIndex = 4;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 53);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(124, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 16);
            label3.TabIndex = 6;
            label3.Text = "DIRECCIÓN IP";
            // 
            // textBoxIp
            // 
            textBoxIp.Location = new Point(124, 116);
            textBoxIp.Name = "textBoxIp";
            textBoxIp.Size = new Size(100, 23);
            textBoxIp.TabIndex = 7;
            textBoxIp.Text = "26.98.235.46";
            textBoxIp.TextChanged += textBoxIp_TextChanged;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(124, 145);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(100, 23);
            textBoxPort.TabIndex = 8;
            textBoxPort.Text = "1433";
            textBoxPort.TextChanged += textBoxPort_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(124, 200);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 9;
            label4.Text = "BASE DE DATOS";
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Location = new Point(124, 219);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(97, 23);
            comboBoxDataBase.TabIndex = 10;
            comboBoxDataBase.SelectedIndexChanged += comboBoxDataBase_SelectedIndexChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(227, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 261);
            Controls.Add(btnLogin);
            Controls.Add(comboBoxDataBase);
            Controls.Add(label4);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIp);
            Controls.Add(label3);
            Controls.Add(btnConnect);
            Controls.Add(textBoxPass);
            Controls.Add(label2);
            Controls.Add(textBoxUser);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUser;
        private Button btnConnect;
        private TextBox textBoxPass;
        private Label label2;
        private Label label3;
        private TextBox textBoxIp;
        private TextBox textBoxPort;
        private Label label4;
        private ComboBox comboBoxDataBase;
        private Button btnLogin;
    }
}