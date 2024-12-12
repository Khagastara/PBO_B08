using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_B08.App.Context;
using PBO_B08.App.Core;
using PBO_B08.App.Model;
using PBO_B08.Views;

namespace PBO_B08
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ClearTextBox()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            C_Login cLogin = new C_Login();
            M_Akun login = cLogin.Validate(usernameTextBox.Text, passwordTextBox.Text);

            if (login != null)
            {
                try
                {
                    UserSession.LoggedInDoctorId = login.idDokter;

                    this.Hide();
                    V_HalUtama halamanUtama = new V_HalUtama();
                    halamanUtama.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else if (string.IsNullOrEmpty(usernameTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Username & Password tidak boleh kosong!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Username atau Password salah. Masukkan dengan benar!", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Tampilkan dialog konfirmasi sebelum keluar
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                                                  "Konfirmasi Keluar",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Jika pengguna memilih "Yes", keluar dari aplikasi
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLupaPass_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
