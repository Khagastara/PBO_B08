﻿namespace PBO_B08.Views
{
    partial class V_AddPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AddPasien));
            roundedPanel1 = new customeToolBox.RoundedPanel();
            roundedPanel6 = new customeToolBox.RoundedPanel();
            txtAlamat = new TextBox();
            roundedPanel5 = new customeToolBox.RoundedPanel();
            txtNoTelepon = new TextBox();
            roundedPanel4 = new customeToolBox.RoundedPanel();
            dateTglLahir = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            roundedPanel3 = new customeToolBox.RoundedPanel();
            cmbJenisKelamin = new ComboBox();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            txtNamaPasien = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnTambah = new customeToolBox.RoundedButton();
            btnKembali = new customeToolBox.RoundedButton();
            roundedPanel1.SuspendLayout();
            roundedPanel6.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel3.SuspendLayout();
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
            roundedPanel1.Controls.Add(roundedPanel6);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(roundedPanel3);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(91, 85);
            roundedPanel1.Margin = new Padding(4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(1062, 600);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Paint += roundedPanel1_Paint_1;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.White;
            roundedPanel6.BackgroundImageLayout = ImageLayout.None;
            roundedPanel6.BorderColor = Color.Transparent;
            roundedPanel6.BorderRadius = 20;
            roundedPanel6.BorderWidth = 2;
            roundedPanel6.Controls.Add(txtAlamat);
            roundedPanel6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel6.Location = new Point(51, 519);
            roundedPanel6.Margin = new Padding(4);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(562, 56);
            roundedPanel6.TabIndex = 5;
            // 
            // txtAlamat
            // 
            txtAlamat.BorderStyle = BorderStyle.None;
            txtAlamat.Location = new Point(20, 12);
            txtAlamat.Margin = new Padding(4);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(525, 30);
            txtAlamat.TabIndex = 3;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.BackgroundImageLayout = ImageLayout.None;
            roundedPanel5.BorderColor = Color.Transparent;
            roundedPanel5.BorderRadius = 20;
            roundedPanel5.BorderWidth = 2;
            roundedPanel5.Controls.Add(txtNoTelepon);
            roundedPanel5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel5.Location = new Point(51, 405);
            roundedPanel5.Margin = new Padding(4);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(562, 56);
            roundedPanel5.TabIndex = 5;
            // 
            // txtNoTelepon
            // 
            txtNoTelepon.BorderStyle = BorderStyle.None;
            txtNoTelepon.Location = new Point(20, 14);
            txtNoTelepon.Margin = new Padding(4);
            txtNoTelepon.Name = "txtNoTelepon";
            txtNoTelepon.Size = new Size(525, 30);
            txtNoTelepon.TabIndex = 2;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.White;
            roundedPanel4.BackgroundImageLayout = ImageLayout.None;
            roundedPanel4.BorderColor = Color.Transparent;
            roundedPanel4.BorderRadius = 20;
            roundedPanel4.BorderWidth = 2;
            roundedPanel4.Controls.Add(dateTglLahir);
            roundedPanel4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel4.Location = new Point(51, 294);
            roundedPanel4.Margin = new Padding(4);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(562, 56);
            roundedPanel4.TabIndex = 4;
            // 
            // dateTglLahir
            // 
            dateTglLahir.Location = new Point(24, 9);
            dateTglLahir.Margin = new Padding(4);
            dateTglLahir.Name = "dateTglLahir";
            dateTglLahir.Size = new Size(520, 37);
            dateTglLahir.TabIndex = 0;
            dateTglLahir.ValueChanged += dateTglLahir_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 481);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(113, 34);
            label5.TabIndex = 6;
            label5.Text = "Alamat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(51, 368);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(223, 34);
            label4.TabIndex = 5;
            label4.Text = "Nomor Telepon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 34);
            label3.TabIndex = 4;
            label3.Text = "Tanggal Lahir";
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.White;
            roundedPanel3.BackgroundImageLayout = ImageLayout.None;
            roundedPanel3.BorderColor = Color.Transparent;
            roundedPanel3.BorderRadius = 20;
            roundedPanel3.BorderWidth = 2;
            roundedPanel3.Controls.Add(cmbJenisKelamin);
            roundedPanel3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel3.Location = new Point(51, 181);
            roundedPanel3.Margin = new Padding(4);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(562, 56);
            roundedPanel3.TabIndex = 3;
            // 
            // cmbJenisKelamin
            // 
            cmbJenisKelamin.FormattingEnabled = true;
            cmbJenisKelamin.Location = new Point(20, 10);
            cmbJenisKelamin.Margin = new Padding(4);
            cmbJenisKelamin.Name = "cmbJenisKelamin";
            cmbJenisKelamin.Size = new Size(524, 36);
            cmbJenisKelamin.TabIndex = 0;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundImageLayout = ImageLayout.None;
            roundedPanel2.BorderColor = Color.Transparent;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(txtNamaPasien);
            roundedPanel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel2.Location = new Point(51, 75);
            roundedPanel2.Margin = new Padding(4);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(562, 56);
            roundedPanel2.TabIndex = 2;
            // 
            // txtNamaPasien
            // 
            txtNamaPasien.BorderStyle = BorderStyle.None;
            txtNamaPasien.Location = new Point(20, 12);
            txtNamaPasien.Margin = new Padding(4);
            txtNamaPasien.Name = "txtNamaPasien";
            txtNamaPasien.Size = new Size(525, 30);
            txtNamaPasien.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 34);
            label2.TabIndex = 1;
            label2.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 0;
            label1.Text = "Nama Pasien";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(4, 118, 208);
            btnTambah.BackgroundImageLayout = ImageLayout.None;
            btnTambah.BorderColor = Color.Transparent;
            btnTambah.BorderRadius = 20;
            btnTambah.BorderWidth = 2;
            btnTambah.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.ImageAlignment = ContentAlignment.MiddleLeft;
            btnTambah.Location = new Point(306, 736);
            btnTambah.Margin = new Padding(4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(156, 56);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(4, 118, 208);
            btnKembali.BackgroundImageLayout = ImageLayout.None;
            btnKembali.BorderColor = Color.Transparent;
            btnKembali.BorderRadius = 20;
            btnKembali.BorderWidth = 2;
            btnKembali.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.ImageAlignment = ContentAlignment.MiddleLeft;
            btnKembali.Location = new Point(799, 736);
            btnKembali.Margin = new Padding(4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(156, 56);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // V_AddPasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(roundedPanel1);
            Margin = new Padding(4);
            Name = "V_AddPasien";
            Size = new Size(1587, 1024);
            Load += V_AddPasien_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel6.ResumeLayout(false);
            roundedPanel6.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel3.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private Label label3;
        private customeToolBox.RoundedPanel roundedPanel3;
        private customeToolBox.RoundedPanel roundedPanel2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private customeToolBox.RoundedPanel roundedPanel6;
        private TextBox txtAlamat;
        private customeToolBox.RoundedPanel roundedPanel5;
        private TextBox txtNoTelepon;
        private customeToolBox.RoundedPanel roundedPanel4;
        private ComboBox cmbJenisKelamin;
        private TextBox txtNamaPasien;
        private customeToolBox.RoundedButton btnTambah;
        private customeToolBox.RoundedButton btnKembali;
        private DateTimePicker dateTglLahir;
    }
}
