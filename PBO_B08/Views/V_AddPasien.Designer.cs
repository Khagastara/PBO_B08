namespace PBO_B08.Views
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
            roundedPanel1 = new customeToolBox.RoundedPanel();
            label1 = new Label();
            txtNamaPasien = new TextBox();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(4, 118, 208);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderWidth = 2;
            roundedPanel1.Controls.Add(txtNamaPasien);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(114, 112);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(800, 360);
            roundedPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 0;
            label1.Text = "Nama Pasien";
            // 
            // txtNamaPasien
            // 
            txtNamaPasien.Location = new Point(38, 56);
            txtNamaPasien.Name = "txtNamaPasien";
            txtNamaPasien.Size = new Size(300, 27);
            txtNamaPasien.TabIndex = 1;
            // 
            // V_AddPasien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundedPanel1);
            Name = "V_AddPasien";
            Size = new Size(1040, 720);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private customeToolBox.RoundedPanel roundedPanel1;
        private TextBox txtNamaPasien;
        private Label label1;
    }
}
