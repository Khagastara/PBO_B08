﻿using PBO_B08.App.Context;
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
                DataTable dataObat = C_Obat.All();
                dataGridViewObat.DataSource = dataObat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}");
            }
        }
    }
}
