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
    public partial class V_LupaPass : Form
    {
        public V_LupaPass()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            V_Login loginForm = new V_Login();
            loginForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string newUsername = txtUser.Text;
            string newPassword = txtpass.Text;
            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong, silakan isi dengan lengkap.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ambil ID dokter yang sedang login
            int doctorId = UserSession.LoggedInDoctorId;
            C_Login loginController = new C_Login();
            loginController.UpdateUserProfile(doctorId, newUsername, newPassword);
            MessageBox.Show("Username dan Password berhasil dirubah.");
        }


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
