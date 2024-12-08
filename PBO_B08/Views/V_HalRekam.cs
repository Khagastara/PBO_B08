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
    public partial class V_HalRekam : UserControl
    {
        public V_HalRekam()
        {
            InitializeComponent();
            this.Load += V_HalRekam_Load;
        }

        private void V_HalRekam_Load(object sender, EventArgs e)
        {
            LoadDataRekam();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadDataRekam()
        {
            try
            {
                dgvRekamMedis.AllowUserToAddRows = false;

                // Ambil data rekam medis dari database
                DataTable dataRekam = C_HalPemeriksaan.All();
                if (dataRekam == null)
                {
                    MessageBox.Show("Error: Gagal Mengambil Data Rekam Medis");
                    return;
                }

                // Tampilkan data pada DataGridView
                dgvRekamMedis.Columns.Clear();
                dgvRekamMedis.DataSource = dataRekam;

                // Ubah header dan visibilitas kolom sesuai kebutuhan
                if (dgvRekamMedis.Columns["idRekam"] != null) dgvRekamMedis.Columns["idRekam"].Visible = false;
                if (dgvRekamMedis.Columns["namaPasien"] != null) dgvRekamMedis.Columns["namaPasien"].HeaderText = "Nama Pasien";
                if (dgvRekamMedis.Columns["namaDokter"] != null) dgvRekamMedis.Columns["namaDokter"].HeaderText = "Nama Dokter";
                if (dgvRekamMedis.Columns["tanggalPemeriksaan"] != null) dgvRekamMedis.Columns["tanggalPemeriksaan"].HeaderText = "Tanggal Pemeriksaan";
                if (dgvRekamMedis.Columns["hasilPemeriksaan"] != null) dgvRekamMedis.Columns["hasilPemeriksaan"].HeaderText = "Hasil Pemeriksaan";
                if (dgvRekamMedis.Columns["Diagnosis"] != null) dgvRekamMedis.Columns["Diagnosis"].HeaderText = "Diagnosis";
                if (dgvRekamMedis.Columns["namaObat"] != null) dgvRekamMedis.Columns["namaObat"].HeaderText = "namaObat";

                // Tambahkan kolom nomor urut
                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "No",
                    Name = "Nomor"
                };
                dgvRekamMedis.Columns.Insert(0, nomorColumn);

                // Isi kolom nomor urut
                for (int i = 0; i < dgvRekamMedis.Rows.Count; i++)
                {
                    dgvRekamMedis.Rows[i].Cells["Nomor"].Value = (i + 1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataRekam: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnAddPasien_Click(object sender, EventArgs e)
        {
            V_PilihPasien v_pilihPasien = new V_PilihPasien();

            V_HalUtama.panel1.Controls.Clear();
            V_HalUtama.panel1.Controls.Add(v_pilihPasien);
            v_pilihPasien.Dock = DockStyle.Fill;
        }
    }
}
