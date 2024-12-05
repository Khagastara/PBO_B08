namespace PBO_B08.Views
{
    partial class V_Logout
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
            btnIya = new Button();
            btnTidak = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 67);
            label1.Name = "label1";
            label1.Size = new Size(445, 40);
            label1.TabIndex = 0;
            label1.Text = "Apakah Anda yakin Ingin Logout?";
            label1.Click += label1_Click;
            // 
            // btnIya
            // 
            btnIya.BackColor = Color.Blue;
            btnIya.Location = new Point(50, 255);
            btnIya.Name = "btnIya";
            btnIya.Size = new Size(140, 59);
            btnIya.TabIndex = 1;
            btnIya.Text = "Iya";
            btnIya.UseVisualStyleBackColor = false;
            btnIya.Click += btnIya_Click;
            // 
            // btnTidak
            // 
            btnTidak.BackColor = Color.Red;
            btnTidak.Location = new Point(502, 255);
            btnTidak.Name = "btnTidak";
            btnTidak.Size = new Size(140, 59);
            btnTidak.TabIndex = 2;
            btnTidak.Text = "Tidak";
            btnTidak.UseVisualStyleBackColor = false;
            btnTidak.Click += btnTidak_Click;
            // 
            // V_Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 118, 208);
            Controls.Add(btnTidak);
            Controls.Add(btnIya);
            Controls.Add(label1);
            Location = new Point(250, 200);
            Name = "V_Logout";
            Size = new Size(704, 492);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIya;
        private Button btnTidak;
    }
}
