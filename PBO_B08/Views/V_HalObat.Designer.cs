namespace PBO_B08.Views
{
    partial class V_HalObat
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
            dataGridViewObat = new DataGridView();
            btnAddObat = new customeToolBox.RoundedButton();
            label1 = new Label();
            roundedPanel2 = new customeToolBox.RoundedPanel();
            txtTambahObat = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewObat).BeginInit();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewObat
            // 
            dataGridViewObat.BackgroundColor = Color.White;
            dataGridViewObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewObat.Location = new Point(38, 95);
            dataGridViewObat.Name = "dataGridViewObat";
            dataGridViewObat.RowHeadersWidth = 51;
            dataGridViewObat.Size = new Size(935, 477);
            dataGridViewObat.TabIndex = 1;
            // 
            // btnAddObat
            // 
            btnAddObat.BackColor = Color.FromArgb(4, 118, 208);
            btnAddObat.BorderColor = Color.Transparent;
            btnAddObat.BorderRadius = 20;
            btnAddObat.BorderWidth = 2;
            btnAddObat.FlatAppearance.BorderSize = 0;
            btnAddObat.FlatStyle = FlatStyle.Flat;
            btnAddObat.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddObat.ForeColor = Color.White;
            btnAddObat.ImageAlignment = ContentAlignment.MiddleLeft;
            btnAddObat.Location = new Point(841, 610);
            btnAddObat.Name = "btnAddObat";
            btnAddObat.Size = new Size(133, 45);
            btnAddObat.TabIndex = 7;
            btnAddObat.Text = "Tambah";
            btnAddObat.UseVisualStyleBackColor = false;
            btnAddObat.Click += TambahObat_Cliick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(172, 34);
            label1.TabIndex = 8;
            label1.Text = "Daftar Obat";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.White;
            roundedPanel2.BackgroundImageLayout = ImageLayout.None;
            roundedPanel2.BorderColor = Color.Transparent;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderWidth = 2;
            roundedPanel2.Controls.Add(txtTambahObat);
            roundedPanel2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedPanel2.Location = new Point(368, 610);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(450, 45);
            roundedPanel2.TabIndex = 9;
            roundedPanel2.Paint += roundedPanel2_Paint;
            // 
            // txtTambahObat
            // 
            txtTambahObat.BorderStyle = BorderStyle.None;
            txtTambahObat.Location = new Point(18, 11);
            txtTambahObat.Name = "txtTambahObat";
            txtTambahObat.Size = new Size(420, 25);
            txtTambahObat.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 118, 208);
            label3.Location = new Point(159, 614);
            label3.Name = "label3";
            label3.Size = new Size(200, 34);
            label3.TabIndex = 11;
            label3.Text = "Tambah Obat";
            // 
            // V_HalObat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label3);
            Controls.Add(roundedPanel2);
            Controls.Add(label1);
            Controls.Add(btnAddObat);
            Controls.Add(dataGridViewObat);
            Name = "V_HalObat";
            Size = new Size(1024, 673);
            ((System.ComponentModel.ISupportInitialize)dataGridViewObat).EndInit();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewObat;
        private customeToolBox.RoundedButton btnAddObat;
        private Label label1;
        private customeToolBox.RoundedPanel roundedPanel2;
        private TextBox txtTambahObat;
        private Label label3;
    }
}
