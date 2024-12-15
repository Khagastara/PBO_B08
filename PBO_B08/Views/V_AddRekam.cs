using PBO_B08.App.Context;
using PBO_B08.App.Core;
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
    public partial class V_AddRekam : UserControl
    {
        private int loggedInDoctorId;
        private int selectedPatientId;

        public V_AddRekam(int selectedPatientId)
        {
            InitializeComponent();

            this.selectedPatientId = selectedPatientId;
            this.loggedInDoctorId = UserSession.LoggedInDoctorId;
            this.Load += V_AddRekam_Load;
        }


        private void V_AddRekam_Load(object sender, EventArgs e)
        {
            LoadObatList();

            M_Pemeriksaan m_Pemeriksaan = new M_Pemeriksaan();
            m_Pemeriksaan.tanggalPemeriksaan = DateTime.Today;
        }

        private void txtDiagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void listObatBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadObatList()
        {
            try
            {
                DataTable dataObat = C_HalPemeriksaan.getObatList();
                listObatBox.Items.Clear();

                foreach (DataRow row in dataObat.Rows)
                {
                    string itemName = row["namaObat"].ToString();
                    int itemId = Convert.ToInt32(row["idObat"]);

                    listObatBox.Items.Add(new ListItem { Name = itemName, Value = itemId });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        public class ListItem
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        private void ClearForm()
        {
            txtHasil.Clear();
            txtDiagnosis.Clear();
            foreach (int index in listObatBox.CheckedIndices)
            {
                listObatBox.SetItemCheckState(index, CheckState.Unchecked);
            }
        }

        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(txtHasil.Text) &&
                   !string.IsNullOrWhiteSpace(txtDiagnosis.Text) &&
                   listObatBox.CheckedItems.Count > 0;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    MessageBox.Show("Inputan tidak valid.");
                    return;
                }

                if (!C_HalPemeriksaan.DoctorExists(loggedInDoctorId))
                {
                    MessageBox.Show("Dokter tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create and add the medical record
                M_Pemeriksaan pemeriksaan = new M_Pemeriksaan
                {
                    idDokter = loggedInDoctorId,
                    idPasien = selectedPatientId,
                    tanggalPemeriksaan = DateTime.Today
                };

                int idRekam = C_HalPemeriksaan.addPemeriksaan(pemeriksaan);

                foreach (ListItem item in listObatBox.CheckedItems)
                {
                    M_HasilPemeriksaan hasilPemeriksaan = new M_HasilPemeriksaan
                    {
                        idRekam = idRekam,
                        hasilPemeriksaan = txtHasil.Text,
                        diagnosis = txtDiagnosis.Text,
                        idObat = item.Value
                    };

                    C_HalPemeriksaan.addHasilPemeriksaan(hasilPemeriksaan);
                }

                MessageBox.Show("Rekam medis berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

                V_HalRekam v_HalRekam = new V_HalRekam();

                V_HalUtama.panel1.Controls.Clear();
                V_HalUtama.panel1.Controls.Add(v_HalRekam);
                v_HalRekam.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            V_PilihPasien v_pilihPasien = new V_PilihPasien();

            V_HalUtama.panel1.Controls.Clear();
            V_HalUtama.panel1.Controls.Add(v_pilihPasien);
            v_pilihPasien.Dock = DockStyle.Fill;
        }
    }
}
