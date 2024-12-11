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
            ((System.ComponentModel.ISupportInitialize)dataGridViewObat).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewObat
            // 
            dataGridViewObat.BackgroundColor = Color.White;
            dataGridViewObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewObat.Location = new Point(48, 159);
            dataGridViewObat.Margin = new Padding(4);
            dataGridViewObat.Name = "dataGridViewObat";
            dataGridViewObat.RowHeadersWidth = 51;
            dataGridViewObat.Size = new Size(1169, 596);
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
            btnAddObat.Location = new Point(1050, 762);
            btnAddObat.Margin = new Padding(4);
            btnAddObat.Name = "btnAddObat";
            btnAddObat.Size = new Size(166, 56);
            btnAddObat.TabIndex = 7;
            btnAddObat.Text = "Tambah";
            btnAddObat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 118, 208);
            label1.Location = new Point(48, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 39);
            label1.TabIndex = 8;
            label1.Text = "Daftar Obat";
            // 
            // V_HalObat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnAddObat);
            Controls.Add(dataGridViewObat);
            Margin = new Padding(4);
            Name = "V_HalObat";
            Size = new Size(1280, 841);
            ((System.ComponentModel.ISupportInitialize)dataGridViewObat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewObat;
        private customeToolBox.RoundedButton btnAddObat;
        private Label label1;
    }
}
