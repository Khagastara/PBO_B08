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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHomepage = new customeToolBox.RoundedButton();
            panel2 = new Panel();
            roundedButton4 = new customeToolBox.RoundedButton();
            btnPemeriksaan = new customeToolBox.RoundedButton();
            btnPasien = new customeToolBox.RoundedButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(238, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 673);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            btnHomepage.Location = new Point(12, 160);
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
            panel2.Controls.Add(roundedButton4);
            panel2.Controls.Add(btnPemeriksaan);
            panel2.Controls.Add(btnPasien);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnHomepage);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 720);
            panel2.TabIndex = 2;
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
            roundedButton4.ImageAlignment = ContentAlignment.MiddleLeft;
            roundedButton4.Location = new Point(12, 329);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(220, 50);
            roundedButton4.TabIndex = 7;
            roundedButton4.Text = "Homepage";
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
            btnPemeriksaan.Location = new Point(12, 272);
            btnPemeriksaan.Name = "btnPemeriksaan";
            btnPemeriksaan.Size = new Size(220, 50);
            btnPemeriksaan.TabIndex = 6;
            btnPemeriksaan.Text = "   Rekam Medis";
            btnPemeriksaan.UseVisualStyleBackColor = false;
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
            btnPasien.Image = Properties.Resources.imgbin_patient_icon_blood_donation_icon_png;
            btnPasien.ImageAlignment = ContentAlignment.MiddleLeft;
            btnPasien.Location = new Point(12, 216);
            btnPasien.Name = "btnPasien";
            btnPasien.Size = new Size(220, 50);
            btnPasien.TabIndex = 5;
            btnPasien.Text = "Data Pasien";
            btnPasien.UseVisualStyleBackColor = false;
            btnPasien.Click += btnPasien_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Tool";
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
        public static Panel panel1;
    }
}