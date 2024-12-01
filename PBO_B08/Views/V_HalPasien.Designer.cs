namespace PBO_B08.Views
{
    partial class V_HalPasien
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
            dataGridView1 = new DataGridView();
            btnAddPasien = new customeToolBox.RoundedButton();
            txtTelusuri = new TextBox();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            btnTelusuri = new customeToolBox.RoundedButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(935, 477);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            btnAddPasien.TabIndex = 1;
            btnAddPasien.Text = "Tambah";
            btnAddPasien.UseVisualStyleBackColor = false;
            btnAddPasien.Click += btnAddPasien_Click;
            // 
            // txtTelusuri
            // 
            txtTelusuri.BorderStyle = BorderStyle.None;
            txtTelusuri.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelusuri.Location = new Point(16, 9);
            txtTelusuri.Name = "txtTelusuri";
            txtTelusuri.Size = new Size(758, 25);
            txtTelusuri.TabIndex = 2;
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
            roundedPanel1.TabIndex = 3;
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
            btnTelusuri.TabIndex = 4;
            btnTelusuri.Text = "Telusuri";
            btnTelusuri.UseVisualStyleBackColor = false;
            btnTelusuri.Click += btnTelusuri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 34);
            label1.TabIndex = 5;
            label1.Text = "Data Pasien";
            // 
            // V_HalPasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label1);
            Controls.Add(btnTelusuri);
            Controls.Add(roundedPanel1);
            Controls.Add(btnAddPasien);
            Controls.Add(dataGridView1);
            Name = "V_HalPasien";
            Size = new Size(1024, 673);
            Load += V_HalPasien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private customeToolBox.RoundedButton btnAddPasien;
        private TextBox txtTelusuri;
        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedButton btnTelusuri;
        private Label label1;
    }
}
