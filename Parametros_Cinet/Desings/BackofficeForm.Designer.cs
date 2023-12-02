namespace Parametros_Cinet.Desings
{
    partial class BackofficeForm
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
            materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            materialRaisedButton1.AutoSize = true;
            materialRaisedButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialRaisedButton1.Depth = 0;
            materialRaisedButton1.Icon = null;
            materialRaisedButton1.Location = new Point(12, 12);
            materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRaisedButton1.Name = "materialRaisedButton1";
            materialRaisedButton1.Primary = true;
            materialRaisedButton1.Size = new Size(83, 36);
            materialRaisedButton1.TabIndex = 1;
            materialRaisedButton1.Text = "Delivery";
            materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // BackofficeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 154);
            Controls.Add(materialRaisedButton1);
            Name = "BackofficeForm";
            Text = "BackofficeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}