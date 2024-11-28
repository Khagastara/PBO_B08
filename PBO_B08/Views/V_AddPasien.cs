using PBO_B08.App.Model;
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
    public partial class V_AddPasien : UserControl
    {
        private bool IsEditMode { get; set; } = false;
        private int PasienId { get; set; }
        public V_AddPasien()
        {
            InitializeComponent();
        }

        private void V_AddPasien_Load(object sender, EventArgs e)
        {
            LoadJenisKelamin();
        }
        private void LoadJenisKelamin()
        {
            cmbJenisKelamin.Items.Clear();
            cmbJenisKelamin.Items.Add("Laki-laki");
            cmbJenisKelamin.Items.Add("Perempuan");
            cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList; // Ensure the user selects only the predefined values
        }

        public void ClearTextBox()
        {
            txtNamaPasien.Text = "";
            txtTglLahir.Text = "";
            txtNoTelepon.Text = "";
            txtAlamat.Text = "";
        }

        public void PasienForm(M_Pasien m_Pasien)
        {


            txtNamaPasien.Text = m_Pasien.namaPasien;
            if (cmbJenisKelamin.Items.Contains(m_Pasien.jenisKelamin))
            {
                cmbJenisKelamin.SelectedItem = m_Pasien.jenisKelamin;
            }
            else
            {
                cmbJenisKelamin.SelectedIndex = -1; // If no match, clear selection
            }
            txtTglLahir.Text = m_Pasien.tanggalLahir;
            txtNoTelepon.Text = m_Pasien.noTelepon;
            txtAlamat.Text = m_Pasien.Alamat;
            IsEditMode = true;
            PasienId = m_Pasien.idPasien;
            UpdateButtonText();
        }

        private void UpdateButtonText()
        {
            btnTambah.Text = IsEditMode ? "Update" : "Add";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaPasien.Text) ||
                    string.IsNullOrWhiteSpace(txtTglLahir.Text) ||
                    string.IsNullOrWhiteSpace(txtNoTelepon.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    cmbJenisKelamin.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                M_Pasien pasien = new M_Pasien
                {
                    idPasien = IsEditMode ? PasienId : 0,
                    namaPasien = txtNamaPasien.Text,
                    jenisKelamin = cmbJenisKelamin.SelectedItem.ToString(),
                    tanggalLahir = txtTglLahir.Text,
                    noTelepon = txtNoTelepon.Text,
                    Alamat = txtAlamat.Text
                };

                if (IsEditMode)
                {
                    // Call update logic
                    // Example: C_Pasien.UpdatePasien(pasien);
                    MessageBox.Show("Pasien telah Diedit.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pasien Telah Ditambah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
