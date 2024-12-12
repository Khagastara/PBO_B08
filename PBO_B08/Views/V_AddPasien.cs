using PBO_B08.App.Model;
using PBO_B08.App.Context;
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
        public static event Action OnPasienUpdated;
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
            cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ClearTextBox()
        {
            txtNamaPasien.Text = "";
            dateTglLahir.Value = DateTime.Today;
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
            dateTglLahir.Value = m_Pasien.tanggalLahir;
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

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaPasien.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(txtNoTelepon.Text) ||
                    cmbJenisKelamin.SelectedIndex == -1)
            {
                return false;
            }
            if (dateTglLahir.Value == null)
            {
                return false;
            }
            return true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    MessageBox.Show("Inputan tidak valid");
                    return;
                }

                M_Pasien pasien = new M_Pasien
                {
                    idPasien = IsEditMode ? PasienId : 0,
                    namaPasien = txtNamaPasien.Text,
                    jenisKelamin = cmbJenisKelamin.SelectedItem.ToString(),
                    tanggalLahir = dateTglLahir.Value,
                    noTelepon = txtNoTelepon.Text,
                    Alamat = txtAlamat.Text
                };

                if (IsEditMode)
                {
                    //C_Pasien.updatePasien(pasien);
                    MessageBox.Show("Pasien telah Diedit.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    C_Pasien.addPasien(pasien);
                    MessageBox.Show("Pasien Telah Ditambah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                OnPasienUpdated?.Invoke();
                ClearTextBox();

                V_HalPasien v_HalPasien = new V_HalPasien();

                V_HalUtama.panel1.Controls.Clear();
                V_HalUtama.panel1.Controls.Add(v_HalPasien);
                v_HalPasien.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTglLahir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            V_HalPasien v_HalPasien = new V_HalPasien();

            V_HalUtama.panel1.Controls.Clear();
            V_HalUtama.panel1.Controls.Add(v_HalPasien);
            v_HalPasien.Dock = DockStyle.Fill;
        }
    }
}
