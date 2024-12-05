using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_B08.Views
{
    public partial class V_HalUtama : Form
    {
        V_HalPasien v_HalPasien = new V_HalPasien();
        V_HalRekam v_HalRekam = new V_HalRekam();
        public V_HalUtama()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHomepage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            V_HalPasien v_HalPasien = new V_HalPasien();

            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalPasien);
            v_HalPasien.Dock = DockStyle.Fill;
        }

        private void btnRekam_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalRekam);
            v_HalRekam.Dock = DockStyle.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            V_Logout logoutControl = new V_Logout();
            logoutControl.Dock = DockStyle.Fill;

            logoutControl.OnLogoutConfirmed += () =>
            {
                V_Login loginForm = new V_Login();
                loginForm.Show();

                this.Close();
            };

            panelOverlay.Controls.Clear(); 
            panelOverlay.Controls.Add(logoutControl);
            panelOverlay.BringToFront();        
            panelOverlay.Visible = true;
            panelOverlay.BackColor = Color.FromArgb(100, 0, 0, 0);
            panelPopup.Location = new Point(
                (panelOverlay.Width - panelPopup.Width) / 2,
                (panelOverlay.Height - panelPopup.Height) / 2
            );
        }
    }
}
