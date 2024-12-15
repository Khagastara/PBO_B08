namespace PBO_B08.Views
{
    partial class V_LupaPass
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
            panel1 = new Panel();
            btn_simpan = new Button();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            txtpass = new TextBox();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_kembali = new Button();
            panel1.SuspendLayout();
            roundedPanel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(4, 118, 208);
            panel1.Controls.Add(btn_simpan);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_kembali);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 600);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_simpan
            // 
            btn_simpan.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_simpan.Location = new Point(149, 380);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(107, 39);
            btn_simpan.TabIndex = 8;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(txtpass);
            roundedPanel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel1.Location = new Point(139, 289);
            roundedPanel1.Margin = new Padding(4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(389, 50);
            roundedPanel1.TabIndex = 7;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Location = new Point(20, 12);
            txtpass.Margin = new Padding(4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(346, 30);
            txtpass.TabIndex = 0;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundImageLayout = ImageLayout.None;
            roundedPanel2.BorderColor = Color.Transparent;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(txtUser);
            roundedPanel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel2.Location = new Point(139, 186);
            roundedPanel2.Margin = new Padding(4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(389, 50);
            roundedPanel2.TabIndex = 6;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(20, 12);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(346, 30);
            txtUser.TabIndex = 0;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(127, 251);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 2;
            label2.Text = "Password Baru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 154);
            label1.Name = "label1";
            label1.Size = new Size(188, 28);
            label1.TabIndex = 1;
            label1.Text = "Username Baru";
            // 
            // btn_kembali
            // 
            btn_kembali.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_kembali.Location = new Point(421, 380);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(107, 39);
            btn_kembali.TabIndex = 0;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = true;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // V_LupaPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_LupaPass";
            Text = "V_LupaPass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_kembali;
        private Label label2;
        private Label label1;
        private customeToolBox.RoundedPanel roundedPanel2;
        private TextBox txtUser;
        private customeToolBox.RoundedPanel roundedPanel1;
        private TextBox txtpass;
        private Button btn_simpan;
    }
}