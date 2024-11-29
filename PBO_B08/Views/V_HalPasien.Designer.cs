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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 86);
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
            btnAddPasien.Location = new Point(840, 588);
            btnAddPasien.Name = "btnAddPasien";
            btnAddPasien.Size = new Size(133, 38);
            btnAddPasien.TabIndex = 1;
            btnAddPasien.Text = "Tambah";
            btnAddPasien.UseVisualStyleBackColor = false;
            btnAddPasien.Click += btnAddPasien_Click;
            // 
            // V_HalPasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btnAddPasien);
            Controls.Add(dataGridView1);
            Name = "V_HalPasien";
            Size = new Size(1024, 673);
            Load += V_HalPasien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private customeToolBox.RoundedButton btnAddPasien;
    }
}
