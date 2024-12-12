namespace PBO_B08.Views
{
    partial class V_AddRekam
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
            btnKembali = new customeToolBox.RoundedButton();
            btnTambah = new customeToolBox.RoundedButton();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            listObatBox = new CheckedListBox();
            roundedPanel5 = new customeToolBox.RoundedPanel();
            txtDiagnosis = new TextBox();
            label5 = new Label();
            label4 = new Label();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            txtHasil = new TextBox();
            label1 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel5.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
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
            btnKembali.Location = new Point(653, 574);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(125, 45);
            btnKembali.TabIndex = 5;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
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
            btnTambah.Location = new Point(259, 574);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(125, 45);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(listObatBox);
            roundedPanel1.Controls.Add(roundedPanel5);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(87, 53);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(850, 480);
            roundedPanel1.TabIndex = 3;
            // 
            // listObatBox
            // 
            listObatBox.FormattingEnabled = true;
            listObatBox.Location = new Point(41, 242);
            listObatBox.Name = "listObatBox";
            listObatBox.Size = new Size(768, 202);
            listObatBox.TabIndex = 7;
            listObatBox.SelectedIndexChanged += listObatBox_SelectedIndexChanged;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.White;
            roundedPanel5.BackgroundImageLayout = ImageLayout.None;
            roundedPanel5.BorderColor = Color.Transparent;
            roundedPanel5.BorderRadius = 20;
            roundedPanel5.BorderWidth = 2;
            roundedPanel5.Controls.Add(txtDiagnosis);
            roundedPanel5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel5.Location = new Point(41, 151);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(450, 45);
            roundedPanel5.TabIndex = 5;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BorderStyle = BorderStyle.None;
            txtDiagnosis.Location = new Point(16, 11);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(420, 25);
            txtDiagnosis.TabIndex = 2;
            txtDiagnosis.TextChanged += txtDiagnosis_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 212);
            label5.Name = "label5";
            label5.Size = new Size(68, 27);
            label5.TabIndex = 6;
            label5.Text = "Obat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(41, 121);
            label4.Name = "label4";
            label4.Size = new Size(119, 27);
            label4.TabIndex = 5;
            label4.Text = "Diagnosis";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundImageLayout = ImageLayout.None;
            roundedPanel2.BorderColor = Color.Transparent;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(txtHasil);
            roundedPanel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel2.Location = new Point(41, 60);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(450, 45);
            roundedPanel2.TabIndex = 2;
            // 
            // txtHasil
            // 
            txtHasil.BorderStyle = BorderStyle.None;
            txtHasil.Location = new Point(16, 10);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(420, 25);
            txtHasil.TabIndex = 0;
            txtHasil.TextChanged += txtHasil_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(216, 27);
            label1.TabIndex = 0;
            label1.Text = "Hasil Pemeriksaan";
            // 
            // V_AddRekam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKembali);
            Controls.Add(btnTambah);
            Controls.Add(roundedPanel1);
            Name = "V_AddRekam";
            Size = new Size(1024, 673);
            Load += V_AddRekam_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel5.ResumeLayout(false);
            roundedPanel5.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private customeToolBox.RoundedButton btnKembali;
        private customeToolBox.RoundedButton btnTambah;
        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedPanel roundedPanel6;
        private TextBox txtAlamat;
        private customeToolBox.RoundedPanel roundedPanel5;
        private TextBox txtDiagnosis;
        private Label label5;
        private Label label4;
        private customeToolBox.RoundedPanel roundedPanel2;
        private TextBox txtHasil;
        private Label label1;
        private CheckedListBox listObatBox;
    }
}
