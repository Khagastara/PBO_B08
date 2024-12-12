namespace PBO_B08.Views
{
    partial class V_PilihPasien
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
            label1 = new Label();
            txtTelusuri = new TextBox();
            btnTelusuri = new customeToolBox.RoundedButton();
            roundedPanel1 = new customeToolBox.RoundedPanel();
            btnKembali = new customeToolBox.RoundedButton();
            dataGridView1 = new DataGridView();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(165, 34);
            label1.TabIndex = 6;
            label1.Text = "Pilih Pasien";
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
            btnTelusuri.Location = new Point(840, 79);
            btnTelusuri.Name = "btnTelusuri";
            btnTelusuri.Size = new Size(133, 41);
            btnTelusuri.TabIndex = 10;
            btnTelusuri.Text = "Telusuri";
            btnTelusuri.UseVisualStyleBackColor = false;
            btnTelusuri.Click += btnTelusuri_Click;
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
            roundedPanel1.TabIndex = 9;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(4, 118, 208);
            btnKembali.BorderColor = Color.Transparent;
            btnKembali.BorderRadius = 20;
            btnKembali.BorderWidth = 2;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKembali.ForeColor = Color.White;
            btnKembali.ImageAlignment = ContentAlignment.MiddleLeft;
            btnKembali.Location = new Point(840, 610);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(133, 45);
            btnKembali.TabIndex = 8;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(935, 477);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // V_PilihPasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTelusuri);
            Controls.Add(roundedPanel1);
            Controls.Add(btnKembali);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "V_PilihPasien";
            Size = new Size(1024, 673);
            Load += V_PilihPasien_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelusuri;
        private customeToolBox.RoundedButton btnTelusuri;
        private customeToolBox.RoundedPanel roundedPanel1;
        private customeToolBox.RoundedButton btnKembali;
        private DataGridView dataGridView1;
    }
}
