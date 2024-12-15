namespace PBO_B08.Views
{
    partial class V_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Homepage));
            roundedPanel1 = new customeToolBox.RoundedPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label_jumlahpasien = new Label();
            label_hasilpemeriksaan = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(pictureBox2);
            roundedPanel1.Controls.Add(pictureBox1);
            roundedPanel1.Controls.Add(label_jumlahpasien);
            roundedPanel1.Controls.Add(label_hasilpemeriksaan);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Location = new Point(109, 120);
            roundedPanel1.Margin = new Padding(4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1062, 600);
            roundedPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(690, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 59);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(157, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 60);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_jumlahpasien
            // 
            label_jumlahpasien.AutoSize = true;
            label_jumlahpasien.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_jumlahpasien.Location = new Point(237, 273);
            label_jumlahpasien.Name = "label_jumlahpasien";
            label_jumlahpasien.Size = new Size(58, 51);
            label_jumlahpasien.TabIndex = 7;
            label_jumlahpasien.Text = "...";
            label_jumlahpasien.Click += label_jumlahpasien_Click;
            // 
            // label_hasilpemeriksaan
            // 
            label_hasilpemeriksaan.AutoSize = true;
            label_hasilpemeriksaan.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hasilpemeriksaan.Location = new Point(768, 273);
            label_hasilpemeriksaan.Name = "label_hasilpemeriksaan";
            label_hasilpemeriksaan.Size = new Size(58, 51);
            label_hasilpemeriksaan.TabIndex = 6;
            label_hasilpemeriksaan.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(626, 335);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(332, 34);
            label4.TabIndex = 5;
            label4.Text = "Total Hasil Pemeriksaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(139, 335);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 34);
            label3.TabIndex = 4;
            label3.Text = "Total Pasien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(43, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(303, 43);
            label1.TabIndex = 6;
            label1.Text = "Selamat Datang";
            // 
            // V_Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(roundedPanel1);
            Name = "V_Homepage";
            Size = new Size(1280, 841);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label_jumlahpasien;
        private Label label_hasilpemeriksaan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
