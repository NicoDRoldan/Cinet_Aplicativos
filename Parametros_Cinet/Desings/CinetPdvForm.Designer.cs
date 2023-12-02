namespace Parametros_Cinet.Desings
{
    partial class CinetPdvForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SERV_DVY = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(12, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(99, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Delivery Hero";
            // 
            // SERV_DVY
            // 
            SERV_DVY.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SERV_DVY.Depth = 0;
            SERV_DVY.Icon = null;
            SERV_DVY.Location = new Point(117, 8);
            SERV_DVY.MouseState = MaterialSkin.MouseState.HOVER;
            SERV_DVY.Name = "SERV_DVY";
            SERV_DVY.Primary = true;
            SERV_DVY.Size = new Size(26, 36);
            SERV_DVY.TabIndex = 6;
            SERV_DVY.UseVisualStyleBackColor = true;
            SERV_DVY.Click += SERV_DVY_Click;
            // 
            // CinetPdvForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(339, 57);
            Controls.Add(SERV_DVY);
            Controls.Add(materialLabel1);
            MaximizeBox = false;
            Name = "CinetPdvForm";
            Text = "CinetPdvForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialRaisedButton SERV_DVY;
    }
}