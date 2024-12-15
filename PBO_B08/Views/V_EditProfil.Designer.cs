namespace PBO_B08.Views
{
    partial class V_EditProfil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundedPanel1 = new customeToolBox.RoundedPanel();
            roundedButton2 = new customeToolBox.RoundedButton();
            roundedButton1 = new customeToolBox.RoundedButton();
            roundedPanel5 = new customeToolBox.RoundedPanel();
            txtPassword = new TextBox();
            label4 = new Label();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            txtUsername = new TextBox();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(roundedButton2);
            roundedPanel1.Controls.Add(roundedButton1);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(109, 120);
            roundedPanel1.Margin = new Padding(4, 4, 4, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1062, 600);
            roundedPanel1.TabIndex = 1;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.White;
            roundedButton2.BorderColor = Color.Black;
            roundedButton2.BorderRadius = 20;
            roundedButton2.BorderWidth = 2;
            roundedButton2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton2.Location = new Point(876, 514);
            roundedButton2.Margin = new Padding(4, 4, 4, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(145, 58);
            roundedButton2.TabIndex = 7;
            roundedButton2.Text = "Kembali";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += btnKembali_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.White;
            roundedButton1.BorderColor = Color.Black;
            roundedButton1.BorderRadius = 20;
            roundedButton1.BorderWidth = 2;
            roundedButton1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton1.Location = new Point(644, 514);
            roundedButton1.Margin = new Padding(4, 4, 4, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(145, 58);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "Simpan";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += btnSimpan_Click;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.BackgroundImageLayout = ImageLayout.None;
            roundedPanel5.BorderColor = Color.Transparent;
            roundedPanel5.BorderRadius = 20;
            roundedPanel5.BorderWidth = 2;
            roundedPanel5.Controls.Add(txtPassword);
            roundedPanel5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel5.Location = new Point(51, 308);
            roundedPanel5.Margin = new Padding(4, 4, 4, 4);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(941, 56);
            roundedPanel5.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(20, 14);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(898, 30);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 254);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(208, 34);
            label4.TabIndex = 5;
            label4.Text = "Password Baru";
            label4.Click += label4_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundImageLayout = ImageLayout.None;
            roundedPanel2.BorderColor = Color.Transparent;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(txtUsername);
            roundedPanel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel2.Location = new Point(51, 144);
            roundedPanel2.Margin = new Padding(4, 4, 4, 4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(941, 56);
            roundedPanel2.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(20, 12);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(898, 30);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(219, 34);
            label1.TabIndex = 0;
            label1.Text = "Username Baru";
            // 
            // V_EditProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "V_EditProfil";
            Size = new Size(1280, 841);
            Load += V_EditProfil_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedPanel roundedPanel5;
        private TextBox txtPassword;
        private Label label4;
        private customeToolBox.RoundedPanel roundedPanel2;
        private TextBox txtUsername;
        private Label label1;
        private customeToolBox.RoundedButton roundedButton1;
        private customeToolBox.RoundedButton roundedButton2;
    }
}
