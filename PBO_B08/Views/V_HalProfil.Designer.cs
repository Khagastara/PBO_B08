namespace PBO_B08.Views
{
    partial class V_HalProfil
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
            customeToolBox.RoundedPanel roundedPanel2;
            customeToolBox.RoundedPanel roundedPanel3;
            roundedPanel1 = new customeToolBox.RoundedPanel();
            label1 = new Label();
            usernameTextBox = new TextBox();
            textBox1 = new TextBox();
            btnEditProfil = new customeToolBox.RoundedButton();
            label2 = new Label();
            label3 = new Label();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            roundedPanel3 = new customeToolBox.RoundedPanel();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(btnEditProfil);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Location = new Point(100, 98);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(824, 475);
            roundedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(65, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 34);
            label1.TabIndex = 1;
            label1.Text = "Profil";
            label1.Click += label1_Click;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(usernameTextBox);
            roundedPanel2.Location = new Point(56, 85);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(704, 50);
            roundedPanel2.TabIndex = 8;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(20, 11);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(660, 30);
            usernameTextBox.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderColor = Color.White;
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.BorderWidth = 2;
            roundedPanel3.Controls.Add(textBox1);
            roundedPanel3.Location = new Point(56, 250);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(704, 50);
            roundedPanel3.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(20, 11);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(660, 30);
            textBox1.TabIndex = 1;
            // 
            // btnEditProfil
            // 
            btnEditProfil.BackColor = Color.White;
            btnEditProfil.BorderColor = Color.Black;
            btnEditProfil.BorderRadius = 20;
            btnEditProfil.BorderWidth = 2;
            btnEditProfil.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfil.ImageAlignment = ContentAlignment.MiddleLeft;
            btnEditProfil.Location = new Point(662, 401);
            btnEditProfil.Name = "btnEditProfil";
            btnEditProfil.Size = new Size(131, 48);
            btnEditProfil.TabIndex = 10;
            btnEditProfil.Text = "Edit Profil";
            btnEditProfil.UseVisualStyleBackColor = false;
            btnEditProfil.Click += btnEditProfil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 50);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 214);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // V_HalProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Name = "V_HalProfil";
            Size = new Size(1024, 673);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private customeToolBox.RoundedButton btnEditProfil;
        private TextBox textBox1;
        private TextBox usernameTextBox;
    }
}
