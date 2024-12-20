﻿using PBO_B08.App.Context;
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
    public partial class V_HalObat : UserControl
    {
        public V_HalObat()
        {
            InitializeComponent();
            LoadDataObat();
        }
        private void LoadDataObat()
        {
            try
            {
                dataGridViewObat.AllowUserToAddRows = false;
                dataGridViewObat.RowHeadersVisible = false;

                DataTable dataObat = C_Obat.All();
                dataGridViewObat.DataSource = dataObat;

                if (dataGridViewObat.Columns["idObat"] != null)
                {
                    dataGridViewObat.Columns["idObat"].HeaderText = "No";
                    dataGridViewObat.Columns["idObat"].Width = 50;
                    dataGridViewObat.Columns["idObat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewObat.Columns["idObat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridViewObat.Columns["namaObat"] != null)
                {
                    dataGridViewObat.Columns["namaObat"].HeaderText = "Nama Obat";
                    dataGridViewObat.Columns["namaObat"].Width = 500;
                    dataGridViewObat.Columns["namaObat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}");
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string namaObat = txtTelusuriObat.Text?.Trim();
            if (string.IsNullOrEmpty(namaObat))
            {
                LoadDataObat();
            }

            try
            {
                dataGridViewObat.AllowUserToAddRows = false;
                dataGridViewObat.RowHeadersVisible = false;

                DataTable dataObat = C_Obat.getObatByName(namaObat);
                dataGridViewObat.DataSource = dataObat;

                if (dataGridViewObat.Columns["idObat"] != null)
                {
                    dataGridViewObat.Columns["idObat"].HeaderText = "No";
                    dataGridViewObat.Columns["idObat"].Width = 50;
                    dataGridViewObat.Columns["idObat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewObat.Columns["idObat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                if (dataGridViewObat.Columns["namaObat"] != null)
                {
                    dataGridViewObat.Columns["namaObat"].HeaderText = "Nama Obat";
                    dataGridViewObat.Columns["namaObat"].Width = 500;
                    dataGridViewObat.Columns["namaObat"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}");
            }
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TambahObat_Cliick(object sender, EventArgs e)
        {
            string namaObat = txtTambahObat.Text.Trim();

            if (string.IsNullOrWhiteSpace(namaObat))
            {
                MessageBox.Show("Nama obat tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (C_Obat.IsObatExists(namaObat))
                {
                    MessageBox.Show("Obat dengan nama tersebut sudah ada.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                M_Obat obatBaru = new M_Obat
                {
                    namaObat = namaObat
                };

                C_Obat.addObat(obatBaru);
                LoadDataObat();

                txtTambahObat.Text = "";

                MessageBox.Show("Obat berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menambahkan obat: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

