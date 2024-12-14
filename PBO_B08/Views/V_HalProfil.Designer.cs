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
            lblUsername = new TextBox();
            lblPassword = new TextBox();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            label3 = new Label();
            label2 = new Label();
            btnEditProfil = new customeToolBox.RoundedButton();
            labelProfil = new Label();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            roundedPanel3 = new customeToolBox.RoundedPanel();
            roundedPanel2.SuspendLayout();
            roundedPanel3.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(lblUsername);
            roundedPanel2.Location = new Point(57, 82);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(685, 50);
            roundedPanel2.TabIndex = 8;
            // 
            // lblUsername
            // 
            lblUsername.BorderStyle = BorderStyle.None;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(21, 11);
            lblUsername.Multiline = true;
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(642, 30);
            lblUsername.TabIndex = 1;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BorderColor = Color.White;
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.BorderWidth = 2;
            roundedPanel3.Controls.Add(lblPassword);
            roundedPanel3.Location = new Point(57, 241);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(685, 50);
            roundedPanel3.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.BorderStyle = BorderStyle.None;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(21, 11);
            lblPassword.Multiline = true;
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(642, 30);
            lblPassword.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(btnEditProfil);
            roundedPanel1.Location = new Point(113, 97);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(807, 470);
            roundedPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(57, 201);
            label3.Name = "label3";
            label3.Size = new Size(115, 27);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(57, 39);
            label2.Name = "label2";
            label2.Size = new Size(125, 27);
            label2.TabIndex = 10;
            label2.Text = "Username";
            // 
            // btnEditProfil
            // 
            btnEditProfil.BackColor = Color.White;
            btnEditProfil.BorderColor = Color.Black;
            btnEditProfil.BorderRadius = 20;
            btnEditProfil.BorderWidth = 2;
            btnEditProfil.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfil.ImageAlignment = ContentAlignment.MiddleLeft;
            btnEditProfil.Location = new Point(642, 396);
            btnEditProfil.Name = "btnEditProfil";
            btnEditProfil.Size = new Size(126, 46);
            btnEditProfil.TabIndex = 0;
            btnEditProfil.Text = "Edit Profil";
            btnEditProfil.UseVisualStyleBackColor = false;
            btnEditProfil.Click += btnEditProfil_Click;
            // 
            // labelProfil
            // 
            labelProfil.AutoSize = true;
            labelProfil.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProfil.ForeColor = Color.FromArgb(4, 118, 208);
            labelProfil.Location = new Point(67, 39);
            labelProfil.Name = "labelProfil";
            labelProfil.Size = new Size(80, 34);
            labelProfil.TabIndex = 1;
            labelProfil.Text = "Profil";
            // 
            // V_HalProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelProfil);
            Controls.Add(roundedPanel1);
            Name = "V_HalProfil";
            Size = new Size(1024, 673);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel3.ResumeLayout(false);
            roundedPanel3.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedButton btnEditProfil;
        private Label labelProfil;
        private TextBox lblUsername;
        private TextBox lblPassword;
        private Label label2;
        private Label label3;
    }
}
