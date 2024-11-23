namespace PBO_B08.Views
{
    partial class V_HalUtama
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            roundedButton1 = new customeToolBox.RoundedButton();
            panel2 = new Panel();
            label2 = new Label();
            roundedButton2 = new customeToolBox.RoundedButton();
            roundedButton3 = new customeToolBox.RoundedButton();
            roundedButton4 = new customeToolBox.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(241, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 0;
            label1.Text = "MED-CHECK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_vector_doctor_icon_png_image_4280176_removebg_preview;
            pictureBox1.Location = new Point(23, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton1.BorderColor = Color.Transparent;
            roundedButton1.BorderRadius = 20;
            roundedButton1.BorderWidth = 2;
            roundedButton1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(12, 160);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(220, 50);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "Homepage";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 118, 208);
            panel2.Controls.Add(roundedButton4);
            panel2.Controls.Add(roundedButton3);
            panel2.Controls.Add(roundedButton2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(roundedButton1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 720);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Tool";
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton2.BorderColor = Color.Transparent;
            roundedButton2.BorderRadius = 20;
            roundedButton2.BorderWidth = 2;
            roundedButton2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton2.ForeColor = Color.White;
            roundedButton2.Location = new Point(12, 216);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(220, 50);
            roundedButton2.TabIndex = 5;
            roundedButton2.Text = "Data Pasien";
            roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton3.BorderColor = Color.Transparent;
            roundedButton3.BorderRadius = 20;
            roundedButton3.BorderWidth = 2;
            roundedButton3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton3.ForeColor = Color.White;
            roundedButton3.Location = new Point(12, 272);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(220, 50);
            roundedButton3.TabIndex = 6;
            roundedButton3.Text = "Rekam Medis";
            roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedButton4
            // 
            roundedButton4.BackColor = Color.FromArgb(4, 118, 208);
            roundedButton4.BorderColor = Color.Transparent;
            roundedButton4.BorderRadius = 20;
            roundedButton4.BorderWidth = 2;
            roundedButton4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton4.ForeColor = Color.White;
            roundedButton4.Location = new Point(12, 329);
            roundedButton4.Name = "roundedButton4";
            roundedButton4.Size = new Size(220, 50);
            roundedButton4.TabIndex = 7;
            roundedButton4.Text = "Homepage";
            roundedButton4.UseVisualStyleBackColor = false;
            // 
            // V_HalUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_HalUtama";
            Text = "V_HalUtama";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private customeToolBox.RoundedButton roundedButton1;
        private Panel panel2;
        private customeToolBox.RoundedButton roundedButton2;
        private Label label2;
        private customeToolBox.RoundedButton roundedButton4;
        private customeToolBox.RoundedButton roundedButton3;
    }
}