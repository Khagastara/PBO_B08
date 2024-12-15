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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace PBO_B08.Views
{
    public partial class V_EditProfil : UserControl
    {
        private bool isPasswordHidden = true;

        public V_EditProfil()
        {
            InitializeComponent();
            LoadSpesialisasi();
            LoadJenisKelamin();

            txtNamaDokter.Text = UserSession.LoggedInDoctor;
            cmbSpesialisasi.SelectedItem = UserSession.LoggedInSpecialize;
            cmbJenisKelamin.SelectedItem = UserSession.LoggedInGender;
            txtEmail.Text = UserSession.LoggedInEmail;
            txtNoTelepon.Text = UserSession.LoggedInPhone;

            txtUsername.Text = UserSession.LoggedInUsername;
            txtPassword.Text = UserSession.LoggedInPassword;

            txtPassword.Text = new string('*', UserSession.LoggedInPassword.Length);
        }

        private void LoadSpesialisasi()
        {
            cmbSpesialisasi.Items.Clear();
            cmbSpesialisasi.Items.Add("Dokter Umum");
            cmbSpesialisasi.Items.Add("Dokter Gigi");
            cmbSpesialisasi.Items.Add("Dokter Kandungan dan Kebidanan");
            cmbSpesialisasi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadJenisKelamin()
        {
            cmbJenisKelamin.Items.Clear();
            cmbJenisKelamin.Items.Add("Laki-laki");
            cmbJenisKelamin.Items.Add("Perempuan");
            cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int doctorId = UserSession.LoggedInDoctorId;
            string name = txtNamaDokter.Text;
            string specialize = cmbSpesialisasi.SelectedItem.ToString();
            string gender = cmbJenisKelamin.SelectedItem.ToString();
            string email = txtEmail.Text;
            string phonenumber = txtNoTelepon.Text;

            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;

            try
            {
                C_Login.UpdateUserProfile(name, specialize, gender, email, phonenumber);
                UserSession.LoggedInDoctor = name;
                UserSession.LoggedInSpecialize = specialize;
                UserSession.LoggedInGender = gender;
                UserSession.LoggedInEmail = email;
                UserSession.LoggedInPhone = phonenumber;

                C_Login.UpdateAccount(doctorId, newUsername, newPassword);

                UserSession.LoggedInUsername = newUsername;
                UserSession.LoggedInPassword = newPassword;

                MessageBox.Show("Profil berhasil diperbarui.");

                V_HalProfil profilform = new V_HalProfil();

                V_HalUtama.panel1.Controls.Clear();
                V_HalUtama.panel1.Controls.Add(profilform);
                profilform.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                btnEye.Image = Properties.Resources.ShowEye;
                txtPassword.Text = UserSession.LoggedInPassword;
                isPasswordHidden = false;
            }
            else
            {
                btnEye.Image = Properties.Resources.HideEye;
                txtPassword.Text = new string('*', UserSession.LoggedInPassword.Length);
                isPasswordHidden = true;
            }
        }
    }
}
