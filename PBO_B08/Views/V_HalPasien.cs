using PBO_B08.App.Context;
using PBO_B08.App.Model;
using PBO_B08.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_B08.Views;

namespace PBO_B08.Views
{
    public partial class V_HalPasien : UserControl
    {
        public V_HalPasien()
        {
            InitializeComponent();
            this.Load += V_HalPasien_Load;
        }

        private void V_HalPasien_Load(object sender, EventArgs e)
        {
            LoadDataPasien();
            V_AddPasien.OnPasienUpdated += LoadDataPasien;
        }

        private void LoadDataPasien()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                DataTable dataPasien = C_Pasien.All();
                if (dataPasien == null)
                {
                    MessageBox.Show("Error: Gagal Mengambil Data Pasien");
                    return;
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataPasien;

                if (dataGridView1.Columns["idPasien"] != null) dataGridView1.Columns["idPasien"].Visible = false;
                if (dataGridView1.Columns["namaPasien"] != null) dataGridView1.Columns["namaPasien"].HeaderText = "Nama Pasien";
                if (dataGridView1.Columns["jenisKelamin"] != null) dataGridView1.Columns["jenisKelamin"].HeaderText = "Jenis Kelamin";
                if (dataGridView1.Columns["tanggalLahir"] != null) dataGridView1.Columns["tanggalLahir"].HeaderText = "Tanggal Lahir";
                if (dataGridView1.Columns["Alamat"] != null) dataGridView1.Columns["Alamat"].HeaderText = "Alamat";

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

                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error dalam LoadDataMahasiswa: {ex.Message}\n{ex.StackTrace}");
            }

        }

        private void btnAddPasien_Click(object sender, EventArgs e)
        {
            V_HalUtama v_halUtama = new V_HalUtama();
            V_AddPasien v_AddPasien = new V_AddPasien();
            v_halUtama.panel1.Controls.Clear();
            v_halUtama.panel1.Controls.Add(v_AddPasien);
            v_AddPasien.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                try
                {
                    int idPasien = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idPasien"].Value);

                    DataTable dataPasien = C_Pasien.getPasienById(idPasien);

                    if (dataPasien.Rows.Count > 0)
                    {
                        DataRow row = dataPasien.Rows[0];
                        M_Pasien pasien = new M_Pasien
                        {
                            idPasien = (int)row["idPasien"],
                            namaPasien = row["namaPasien"].ToString(),
                            jenisKelamin = row["jenisKelamin"].ToString(),
                            tanggalLahir = row["tanggalLahir"] != DBNull.Value ? Convert.ToDateTime(row["tanggalLahir"]) : DateTime.MinValue,
                            noTelepon = row["noTelepon"].ToString(),
                            Alamat = row["Alamat"].ToString()
                        };

                        this.Hide();
                        V_AddPasien v_AddPasien = new V_AddPasien();
                        v_AddPasien.PasienForm(pasien);
                        //if (v_AddPasien.ShowDialog() == DialogResult.OK)
                        //{
                        //    LoadDataPasien();
                        //}
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                try
                {
                    int idPasien = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idPasien"].Value);
                    C_Pasien.deletePasien(idPasien);
                    LoadDataPasien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saat menghapus pasien: {ex.Message}");
                }
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
                DataTable dataPasien = C_Pasien.searchByName(namaPasien);

                if (dataPasien == null || dataPasien.Rows.Count == 0)
                {
                    MessageBox.Show("No patients found with the specified name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataPasien;

                if (dataGridView1.Columns["idPasien"] != null) dataGridView1.Columns["idPasien"].Visible = false;
                if (dataGridView1.Columns["namaPasien"] != null) dataGridView1.Columns["namaPasien"].HeaderText = "Nama Pasien";
                if (dataGridView1.Columns["jenisKelamin"] != null) dataGridView1.Columns["jenisKelamin"].HeaderText = "Jenis Kelamin";
                if (dataGridView1.Columns["tanggalLahir"] != null) dataGridView1.Columns["tanggalLahir"].HeaderText = "Tanggal Lahir";
                if (dataGridView1.Columns["Alamat"] != null) dataGridView1.Columns["Alamat"].HeaderText = "Alamat";

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

                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Update",
                    HeaderText = "Update",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(updateButtonColumn);

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred during search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
