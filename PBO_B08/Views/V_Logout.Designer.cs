namespace PBO_B08.Views
{
    partial class V_Logout
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
            btnYa = new customeToolBox.RoundedButton();
            btnTidak = new customeToolBox.RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 75);
            label1.Name = "label1";
            label1.Size = new Size(424, 37);
            label1.TabIndex = 0;
            label1.Text = "Apakah Anda Ingin Logout?";
            // 
            // btnYa
            // 
            btnYa.BackColor = Color.White;
            btnYa.BackgroundImageLayout = ImageLayout.None;
            btnYa.BorderColor = Color.Transparent;
            btnYa.BorderRadius = 20;
            btnYa.BorderWidth = 2;
            btnYa.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYa.ForeColor = Color.FromArgb(4, 118, 208);
            btnYa.ImageAlignment = ContentAlignment.MiddleLeft;
            btnYa.Location = new Point(108, 172);
            btnYa.Name = "btnYa";
            btnYa.Size = new Size(120, 45);
            btnYa.TabIndex = 1;
            btnYa.Text = "Ya";
            btnYa.UseVisualStyleBackColor = false;
            btnYa.Click += btnYa_Click;
            // 
            // btnTidak
            // 
            btnTidak.BackColor = Color.White;
            btnTidak.BackgroundImageLayout = ImageLayout.None;
            btnTidak.BorderColor = Color.Transparent;
            btnTidak.BorderRadius = 20;
            btnTidak.BorderWidth = 2;
            btnTidak.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTidak.ForeColor = Color.FromArgb(4, 118, 208);
            btnTidak.ImageAlignment = ContentAlignment.MiddleLeft;
            btnTidak.Location = new Point(368, 172);
            btnTidak.Name = "btnTidak";
            btnTidak.Size = new Size(120, 45);
            btnTidak.TabIndex = 2;
            btnTidak.Text = "Tidak";
            btnTidak.UseVisualStyleBackColor = false;
            btnTidak.Click += btnTidak_Click;
            // 
            // V_Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 118, 208);
            ClientSize = new Size(600, 300);
            Controls.Add(btnTidak);
            Controls.Add(btnYa);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Logout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Logout1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private customeToolBox.RoundedButton btnYa;
        private customeToolBox.RoundedButton btnTidak;
    }
}