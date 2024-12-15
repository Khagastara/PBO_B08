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

namespace PBO_B08.Views
{
    public partial class V_PilihPasien : UserControl
    {
        private int loggedInDoctorId;
        private int selectedPatientId;

        public V_PilihPasien()
        {
            InitializeComponent();

            this.selectedPatientId = selectedPatientId;
            this.loggedInDoctorId = UserSession.LoggedInDoctorId;
            this.Load += V_PilihPasien_Load;
        }

        private void V_PilihPasien_Load(object sender, EventArgs e)
        {
            LoadDataPasien();
        }

        public void LoadDataPasien()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;

                DataTable dataPasien = C_HalPemeriksaan.listPasien();
                if (dataPasien == null)
                {
                    MessageBox.Show("Error: Gagal Mengambil Data Pasien");
                    return;
                }

                foreach (DataColumn column in dataPasien.Columns)
                {
                    Console.WriteLine("Column: " + column.ColumnName);
                }

                dataGridView1.Columns.Clear();

                DataColumn noColumn = new DataColumn("No", typeof(int));
                dataPasien.Columns.Add(noColumn);

                for (int i = 0; i < dataPasien.Rows.Count; i++)
                {
                    dataPasien.Rows[i]["No"] = i + 1;
                }

                dataPasien.Columns["No"].SetOrdinal(0);

                dataGridView1.DataSource = dataPasien;

                if (dataGridView1.Columns["idPasien"] != null)
                {
                    dataGridView1.Columns["idPasien"].Visible = false;
                }

                if (dataGridView1.Columns["No"] != null)
                {
                    dataGridView1.Columns["No"].HeaderText = "No";
                    dataGridView1.Columns["No"].Width = 50;
                    dataGridView1.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns["No"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["namaPasien"] != null)
                {
                    dataGridView1.Columns["namaPasien"].HeaderText = "Nama Pasien";
                    dataGridView1.Columns["namaPasien"].Width = 250;
                    dataGridView1.Columns["namaPasien"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["jenisKelamin"] != null)
                {
                    dataGridView1.Columns["jenisKelamin"].HeaderText = "Jenis Kelamin";
                    dataGridView1.Columns["jenisKelamin"].Width = 120;
                    dataGridView1.Columns["jenisKelamin"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["tanggalLahir"] != null)
                {
                    dataGridView1.Columns["tanggalLahir"].HeaderText = "Tanggal Lahir";
                    dataGridView1.Columns["tanggalLahir"].Width = 120;
                    dataGridView1.Columns["tanggalLahir"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["noTelepon"] != null)
                {
                    dataGridView1.Columns["noTelepon"].HeaderText = "No Telepon";
                    dataGridView1.Columns["noTelepon"].Width = 130;
                    dataGridView1.Columns["noTelepon"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridView1.Columns["Alamat"] != null)
                {
                    dataGridView1.Columns["Alamat"].HeaderText = "Alamat";
                    dataGridView1.Columns["Alamat"].Width = 150;
                    dataGridView1.Columns["Alamat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Select",
                    HeaderText = "Select",
                    Text = "Pilih",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(selectButtonColumn);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }
        }

        private void btnTelusuri_Click(object sender, EventArgs e)
        {
            string namaPasien = txtTelusuri.Text?.Trim();
            if (string.IsNullOrEmpty(namaPasien))
            {
                LoadDataPasien();
            }

            try
            {
                DataTable dataPasien = C_HalPemeriksaan.searchByName(namaPasien);

                if (dataPasien == null || dataPasien.Rows.Count == 0)
                {
                    MessageBox.Show("No patients found with the specified name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataPasien;

                if (dataGridView1.Columns["idPasien"] != null) dataGridView1.Columns["idPasien"].Visible = false;
                if (dataGridView1.Columns["namaPasien"] != null) dataGridView1.Columns["namaPasien"].HeaderText = "Nama Pasien";

                DataGridViewTextBoxColumn nomorColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "No",
                    Name = "Nomor"
                };
                dataGridView1.Columns.Insert(0, nomorColumn);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["Nomor"].Value = (i + 1).ToString();
                }

                DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Select",
                    HeaderText = "Select",
                    Text = "Pilih",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(selectButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            V_HalRekam v_halRekam = new V_HalRekam();

            V_HalUtama.panel1.Controls.Clear();
            V_HalUtama.panel1.Controls.Add(v_halRekam);
            v_halRekam.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridView1.Columns["Select"].Index)
                return;

            try
            {
                int selectedPatientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idPasien"].Value);

                V_AddRekam v_addRekam = new V_AddRekam(selectedPatientId);

                V_HalUtama.panel1.Controls.Clear();
                V_HalUtama.panel1.Controls.Add(v_addRekam);
                v_addRekam.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
