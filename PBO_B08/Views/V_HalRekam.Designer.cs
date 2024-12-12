namespace PBO_B08.Views
{
    partial class V_HalRekam
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
            dgvRekamMedis = new DataGridView();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            txtTelusuri = new TextBox();
            btnTelusuri = new customeToolBox.RoundedButton();
            btnAddPasien = new customeToolBox.RoundedButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRekamMedis).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRekamMedis
            // 
            dgvRekamMedis.BackgroundColor = Color.White;
            dgvRekamMedis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRekamMedis.GridColor = SystemColors.ActiveBorder;
            dgvRekamMedis.Location = new Point(38, 127);
            dgvRekamMedis.Name = "dgvRekamMedis";
            dgvRekamMedis.RowHeadersWidth = 51;
            dgvRekamMedis.Size = new Size(935, 477);
            dgvRekamMedis.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BackgroundImageLayout = ImageLayout.None;
            roundedPanel1.BorderColor = Color.Transparent;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(txtTelusuri);
            roundedPanel1.Location = new Point(38, 78);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(791, 43);
            roundedPanel1.TabIndex = 4;
            roundedPanel1.Paint += roundedPanel1_Paint;
            // 
            // txtTelusuri
            // 
            txtTelusuri.BorderStyle = BorderStyle.None;
            txtTelusuri.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelusuri.Location = new Point(16, 9);
            txtTelusuri.Name = "txtTelusuri";
            txtTelusuri.Size = new Size(758, 25);
            txtTelusuri.TabIndex = 8;
            // 
            // btnTelusuri
            // 
            btnTelusuri.BackColor = Color.FromArgb(4, 118, 208);
            btnTelusuri.BackgroundImageLayout = ImageLayout.None;
            btnTelusuri.BorderColor = Color.Transparent;
            btnTelusuri.BorderRadius = 20;
            btnTelusuri.BorderWidth = 2;
            btnTelusuri.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTelusuri.ForeColor = Color.White;
            btnTelusuri.ImageAlignment = ContentAlignment.MiddleLeft;
            btnTelusuri.Location = new Point(840, 78);
            btnTelusuri.Name = "btnTelusuri";
            btnTelusuri.Size = new Size(133, 41);
            btnTelusuri.TabIndex = 5;
            btnTelusuri.Text = "Telusuri";
            btnTelusuri.UseVisualStyleBackColor = false;
            btnTelusuri.Click += label1_Click;
            // 
            // btnAddPasien
            // 
            btnAddPasien.BackColor = Color.FromArgb(4, 118, 208);
            btnAddPasien.BorderColor = Color.Transparent;
            btnAddPasien.BorderRadius = 20;
            btnAddPasien.BorderWidth = 2;
            btnAddPasien.FlatAppearance.BorderSize = 0;
            btnAddPasien.FlatStyle = FlatStyle.Flat;
            btnAddPasien.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPasien.ForeColor = Color.White;
            btnAddPasien.ImageAlignment = ContentAlignment.MiddleLeft;
            btnAddPasien.Location = new Point(840, 610);
            btnAddPasien.Name = "btnAddPasien";
            btnAddPasien.Size = new Size(133, 45);
            btnAddPasien.TabIndex = 6;
            btnAddPasien.Text = "Tambah";
            btnAddPasien.UseVisualStyleBackColor = false;
            btnAddPasien.Click += btnAddPasien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(269, 34);
            label1.TabIndex = 7;
            label1.Text = "Data Rekam Medis";
            label1.Click += label1_Click;
            // 
            // V_HalRekam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnAddPasien);
            Controls.Add(btnTelusuri);
            Controls.Add(roundedPanel1);
            Controls.Add(dgvRekamMedis);
            Name = "V_HalRekam";
            Size = new Size(1024, 673);
            Load += V_HalRekam_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRekamMedis).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRekamMedis;
        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedButton btnTelusuri;
        private customeToolBox.RoundedButton btnAddPasien;
        private Label label1;
        private TextBox txtTelusuri;
    }
}
