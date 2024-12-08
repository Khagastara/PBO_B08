namespace PBO_B08.Views
{
    partial class V_HalUtama
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
            panelOverlay = new Panel();
            panelPopup = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHomepage = new customeToolBox.RoundedButton();
            panel2 = new Panel();
            roundedButton2 = new customeToolBox.RoundedButton();
            roundedButton1 = new customeToolBox.RoundedButton();
            roundedButton4 = new customeToolBox.RoundedButton();
            btnPemeriksaan = new customeToolBox.RoundedButton();
            btnPasien = new customeToolBox.RoundedButton();
            label2 = new Label();
            panel1.SuspendLayout();
            panelOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panelOverlay);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(298, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 841);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelOverlay
            // 
            panelOverlay.BackColor = Color.Black;
            panelOverlay.Controls.Add(panelPopup);
            panelOverlay.Location = new Point(208, 139);
            panelOverlay.Margin = new Padding(4, 4, 4, 4);
            panelOverlay.Name = "panelOverlay";
            panelOverlay.Size = new Size(864, 500);
            panelOverlay.TabIndex = 1;
            panelOverlay.Visible = false;
            // 
            // panelPopup
            // 
            panelPopup.BackColor = Color.White;
            panelPopup.BorderStyle = BorderStyle.FixedSingle;
            panelPopup.Location = new Point(170, 113);
            panelPopup.Margin = new Padding(4, 4, 4, 4);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(624, 374);
            panelPopup.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 0;
            label1.Text = "MED-CHECK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_vector_doctor_icon_png_image_4280176_removebg_preview;
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnHomepage
            // 
            btnHomepage.BackColor = Color.FromArgb(4, 118, 208);
            btnHomepage.BorderColor = Color.Transparent;
            btnHomepage.BorderRadius = 20;
            btnHomepage.BorderWidth = 2;
            btnHomepage.FlatAppearance.BorderSize = 0;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomepage.ForeColor = Color.White;
            btnHomepage.Image = Properties.Resources.pngegg3;
            btnHomepage.ImageAlign = ContentAlignment.MiddleLeft;
            btnHomepage.ImageAlignment = ContentAlignment.MiddleLeft;
            btnHomepage.Location = new Point(15, 179);
            btnHomepage.Margin = new Padding(4, 4, 4, 4);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(275, 62);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 118, 208);
            panel2.Controls.Add(roundedButton2);
            panel2.Controls.Add(roundedButton1);
            panel2.Controls.Add(roundedButton4);
            panel2.Controls.Add(btnPemeriksaan);
            panel2.Controls.Add(btnPasien);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnHomepage);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 900);
            panel2.TabIndex = 2;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 20;
            roundedButton2.BorderWidth = 2;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Image = Properties.Resources.Logout_icon;
            roundedButton2.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton2.Location = new Point(15, 541);
            roundedButton2.Margin = new Padding(4, 4, 4, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(275, 62);
            roundedButton2.TabIndex = 9;
            roundedButton2.Text = "Logout";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += btnLogout_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 20;
            roundedButton1.BorderWidth = 2;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Image = Properties.Resources.Profile_icon3;
            roundedButton1.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton1.Location = new Point(15, 252);
            roundedButton1.Margin = new Padding(4, 4, 4, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(275, 62);
            roundedButton1.TabIndex = 8;
            roundedButton1.Text = "Profil";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton4
            // 
            roundedButton4.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton4.BorderColor = Color.Transparent;
            roundedButton4.BorderRadius = 20;
            roundedButton4.BorderWidth = 2;
            roundedButton4.FlatStyle = FlatStyle.Flat;
            roundedButton4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton4.ForeColor = Color.White;
            roundedButton4.Image = Properties.Resources.Medicine_Icon1;
            roundedButton4.ImageAlign = ContentAlignment.MiddleLeft;
            roundedButton4.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton4.Location = new Point(15, 396);
            roundedButton4.Margin = new Padding(4, 4, 4, 4);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(275, 62);
            roundedButton4.TabIndex = 7;
            roundedButton4.Text = "Obat";
            roundedButton4.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton4.UseVisualStyleBackColor = false;
            // 
            // btnPemeriksaan
            // 
            btnPemeriksaan.BackColor = Color.FromArgb(4, 118, 208);
            btnPemeriksaan.BorderColor = Color.Transparent;
            btnPemeriksaan.BorderRadius = 20;
            btnPemeriksaan.BorderWidth = 2;
            btnPemeriksaan.FlatStyle = FlatStyle.Flat;
            btnPemeriksaan.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPemeriksaan.ForeColor = Color.White;
            btnPemeriksaan.Image = Properties.Resources._97q2oiq7i495p7gcc0h7q7js1n;
            btnPemeriksaan.ImageAlignment = ContentAlignment.MiddleLeft;
            btnPemeriksaan.Location = new Point(15, 470);
            btnPemeriksaan.Margin = new Padding(4, 4, 4, 4);
            btnPemeriksaan.Name = "btnPemeriksaan";
            btnPemeriksaan.Size = new Size(275, 62);
            btnPemeriksaan.TabIndex = 6;
            btnPemeriksaan.Text = "   Rekam Medis";
            btnPemeriksaan.UseVisualStyleBackColor = false;
            btnPemeriksaan.Click += btnRekam_Click;
            // 
            // btnPasien
            // 
            btnPasien.BackColor = Color.FromArgb(4, 118, 208);
            btnPasien.BorderColor = Color.Transparent;
            btnPasien.BorderRadius = 20;
            btnPasien.BorderWidth = 2;
            btnPasien.FlatStyle = FlatStyle.Flat;
            btnPasien.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPasien.ForeColor = Color.White;
            btnPasien.Image = Properties.Resources.imgbin_patient_icon_blood_donation_icon_png2;
            btnPasien.ImageAlignment = ContentAlignment.MiddleLeft;
            btnPasien.Location = new Point(15, 326);
            btnPasien.Margin = new Padding(4, 4, 4, 4);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(275, 62);
            btnPasien.TabIndex = 5;
            btnPasien.Text = " Data Pasien";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 2;
            label2.Text = "Tool";
            // 
            // V_HalUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1578, 841);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "V_HalUtama";
            Text = "V_HalUtama";
            panel1.ResumeLayout(false);
            panelOverlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private customeToolBox.RoundedButton btnHomepage;
        private Panel panel2;
        private customeToolBox.RoundedButton btnPasien;
        private Label label2;
        private customeToolBox.RoundedButton roundedButton4;
        private customeToolBox.RoundedButton btnPemeriksaan;
        private customeToolBox.RoundedButton roundedButton1;
        private customeToolBox.RoundedButton roundedButton2;
        private static Panel panelOverlay;
        private static Panel panelPopup;
        public static Panel panel1;
    }
}