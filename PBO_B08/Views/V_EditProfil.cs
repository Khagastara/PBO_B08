using PBO_B08.App.Context;
using PBO_B08.App.Core;
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
    public partial class V_EditProfil : UserControl
    {
        public V_EditProfil()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;
            int doctorId = UserSession.LoggedInDoctorId;

            C_Login loginController = new C_Login();
            loginController.UpdateUserProfile(doctorId, newUsername, newPassword);

            MessageBox.Show("Profil berhasil diperbarui.");
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            V_HalProfil profilform = new V_HalProfil();

            V_HalUtama.panel1.Controls.Clear();
            V_HalUtama.panel1.Controls.Add(profilform);
            profilform.Dock = DockStyle.Fill;
        }

        private void V_EditProfil_Load(object sender, EventArgs e)
        {

        }
    }
}
