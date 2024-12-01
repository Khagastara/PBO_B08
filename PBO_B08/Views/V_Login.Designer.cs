namespace PBO_B08
{
    partial class V_Login
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
            customeToolBox.RoundedPanel roundedPanel1;
            customeToolBox.RoundedPanel roundedPanel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            usernameTextBox = new TextBox();
            pictureBox2 = new PictureBox();
            passwordTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLogin = new customeToolBox.RoundedButton();
            btnLupaPass = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(usernameTextBox);
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Location = new Point(194, 282);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(472, 50);
            roundedPanel1.TabIndex = 7;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(64, 12);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(400, 30);
            usernameTextBox.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg;
            pictureBox2.Location = new Point(18, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BorderColor = Color.White;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(passwordTextBox);
            roundedPanel2.Controls.Add(pictureBox3);
            roundedPanel2.Location = new Point(194, 376);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(472, 50);
            roundedPanel2.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(64, 12);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(400, 30);
            passwordTextBox.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(18, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 118, 208);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 720);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_vector_doctor_icon_png_image_4280176_removebg_preview;
            pictureBox1.Location = new Point(135, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 350);
            label2.Name = "label2";
            label2.Size = new Size(270, 40);
            label2.TabIndex = 2;
            label2.Text = "di MED-CHECK!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 310);
            label1.Name = "label1";
            label1.Size = new Size(281, 40);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(roundedPanel2);
            panel2.Controls.Add(roundedPanel1);
            panel2.Controls.Add(btnLupaPass);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(398, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 720);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(4, 118, 208);
            btnLogin.BorderColor = Color.Transparent;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderWidth = 2;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.ImageAlignment = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(361, 471);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLupaPass
            // 
            btnLupaPass.BackColor = Color.Transparent;
            btnLupaPass.FlatAppearance.BorderSize = 0;
            btnLupaPass.FlatStyle = FlatStyle.Flat;
            btnLupaPass.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLupaPass.ForeColor = Color.White;
            btnLupaPass.Location = new Point(517, 432);
            btnLupaPass.Name = "btnLupaPass";
            btnLupaPass.Size = new Size(149, 29);
            btnLupaPass.TabIndex = 6;
            btnLupaPass.Text = "Lupa Password?";
            btnLupaPass.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(245, 168);
            label5.Name = "label5";
            label5.Size = new Size(379, 34);
            label5.TabIndex = 4;
            label5.Text = "Login Dengan Akun Dokter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(4, 118, 208);
            label4.Location = new Point(194, 350);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 118, 208);
            label3.Location = new Point(194, 256);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_Login";
            Text = "Login";
            Load += Login_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox usernameTextBox;
        private Button btnLupaPass;
        private customeToolBox.RoundedPanel roundedPanel1;
        private TextBox passwordTextBox;
        private customeToolBox.RoundedButton btnLogin;
    }
}