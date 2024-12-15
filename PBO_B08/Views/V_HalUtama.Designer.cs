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
            panelContent = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHomepage = new customeToolBox.RoundedButton();
            panel2 = new Panel();
            roundedButton2 = new customeToolBox.RoundedButton();
            btnProfil = new customeToolBox.RoundedButton();
            roundedButton4 = new customeToolBox.RoundedButton();
            btnPemeriksaan = new customeToolBox.RoundedButton();
            btnPasien = new customeToolBox.RoundedButton();
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
            panel1.Controls.Add(panelContent);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(238, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 673);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelOverlay
            // 
            panelOverlay.BackColor = Color.Black;
            panelOverlay.Controls.Add(panelPopup);
            panelOverlay.Location = new Point(166, 111);
            panelOverlay.Name = "panelOverlay";
            panelOverlay.Size = new Size(691, 400);
            panelOverlay.TabIndex = 1;
            panelOverlay.Visible = false;
            // 
            // panelPopup
            // 
            panelPopup.BackColor = Color.White;
            panelPopup.BorderStyle = BorderStyle.FixedSingle;
            panelPopup.Location = new Point(136, 90);
            panelPopup.Name = "panelPopup";
            panelPopup.Size = new Size(500, 300);
            panelPopup.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1024, 673);
            panelContent.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "MED-CHECK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_vector_doctor_icon_png_image_4280176_removebg_preview;
            pictureBox1.Location = new Point(23, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
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
            btnHomepage.Location = new Point(12, 143);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(220, 50);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = false;
            btnHomepage.Click += btnHomepage_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 118, 208);
            panel2.Controls.Add(roundedButton2);
            panel2.Controls.Add(btnProfil);
            panel2.Controls.Add(roundedButton4);
            panel2.Controls.Add(btnPemeriksaan);
            panel2.Controls.Add(btnPasien);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnHomepage);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 720);
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
            roundedButton2.Location = new Point(12, 433);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(220, 50);
            roundedButton2.TabIndex = 9;
            roundedButton2.Text = "Logout";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += btnLogout_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(4, 118, 208);
            btnProfil.BorderColor = Color.Transparent;
            btnProfil.BorderRadius = 20;
            btnProfil.BorderWidth = 2;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Image = Properties.Resources.Profile_icon3;
            btnProfil.ImageAlignment = ContentAlignment.MiddleLeft;
            btnProfil.Location = new Point(12, 202);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(220, 50);
            btnProfil.TabIndex = 8;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
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
            roundedButton4.Location = new Point(12, 373);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(220, 50);
            roundedButton4.TabIndex = 7;
            roundedButton4.Text = "Obat";
            roundedButton4.TextAlign = ContentAlignment.MiddleLeft;
            roundedButton4.UseVisualStyleBackColor = false;
            roundedButton4.Click += btnObat_Click;
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
            btnPemeriksaan.Location = new Point(12, 317);
            btnPemeriksaan.Name = "btnPemeriksaan";
            btnPemeriksaan.Size = new Size(220, 50);
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
            btnPasien.Location = new Point(10, 261);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(220, 50);
            btnPasien.TabIndex = 5;
            btnPasien.Text = " Data Pasien";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // V_HalUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_HalUtama";
            Text = "V_HalUtama";
            Load += V_HalUtama_Load;
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
        private customeToolBox.RoundedButton btnPasien;
        private customeToolBox.RoundedButton roundedButton4;
        private customeToolBox.RoundedButton btnPemeriksaan;
        private customeToolBox.RoundedButton btnProfil;
        private customeToolBox.RoundedButton roundedButton2;
        private Panel panelOverlay;
        private Panel panelPopup;
        private Panel panelContent;
        private Panel panel2;
        public static Panel panel1;
    }
}