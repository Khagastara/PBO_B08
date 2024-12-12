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
                dgvRekamMedis.RowHeadersVisible = false;

                DataTable dataRekam = C_HalPemeriksaan.All();
                if (dataRekam == null)
                {
                    MessageBox.Show("Error: Gagal Mengambil Data Rekam Medis");
                    return;
                }

                dgvRekamMedis.Columns.Clear();

                DataColumn noColumn = new DataColumn("No", typeof(int));
                dataRekam.Columns.Add(noColumn);

                for (int i = 0; i < dataRekam.Rows.Count; i++)
                {
                    dataRekam.Rows[i]["No"] = i + 1;
                    Width = 10;
                }

                dataRekam.Columns["No"].SetOrdinal(0);

                dgvRekamMedis.DataSource = dataRekam;

                if (dgvRekamMedis.Columns["No"] != null)
                {
                    dgvRekamMedis.Columns["No"].HeaderText = "No";
                    dgvRekamMedis.Columns["No"].Width = 50;
                    dgvRekamMedis.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvRekamMedis.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvRekamMedis.Columns["namaPasien"] != null)
                {
                    dgvRekamMedis.Columns["namaPasien"].HeaderText = "Nama Pasien";
                    dgvRekamMedis.Columns["namaPasien"].Width = 150;
                    dgvRekamMedis.Columns["namaPasien"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvRekamMedis.Columns["namaDokter"] != null)
                {
                    dgvRekamMedis.Columns["namaDokter"].HeaderText = "Nama Dokter";
                    dgvRekamMedis.Columns["namaDokter"].Width = 150;
                    dgvRekamMedis.Columns["namaDokter"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvRekamMedis.Columns["tanggalPemeriksaan"] != null)
                {
                    dgvRekamMedis.Columns["tanggalPemeriksaan"].HeaderText = "Tanggal Pemeriksaan";
                    dgvRekamMedis.Columns["tanggalPemeriksaan"].Width = 120;
                    dgvRekamMedis.Columns["tanggalPemeriksaan"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dgvRekamMedis.Columns["hasilPemeriksaan"] != null)
                {
                    dgvRekamMedis.Columns["hasilPemeriksaan"].HeaderText = "Hasil Pemeriksaan";
                    dgvRekamMedis.Columns["hasilPemeriksaan"].Width = 200;
                    dgvRekamMedis.Columns["hasilPemeriksaan"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvRekamMedis.Columns["Diagnosis"] != null)
                {
                    dgvRekamMedis.Columns["Diagnosis"].HeaderText = "Diagnosis";
                    dgvRekamMedis.Columns["Diagnosis"].Width = 120;
                    dgvRekamMedis.Columns["Diagnosis"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvRekamMedis.Columns["Obat"] != null)
                {
                    dgvRekamMedis.Columns["Obat"].HeaderText = "Daftar Obat";
                    dgvRekamMedis.Columns["Obat"].Width = 300;
                    dgvRekamMedis.Columns["Obat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
