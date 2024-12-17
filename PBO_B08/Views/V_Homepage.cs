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
    public partial class V_Homepage : UserControl
    {
        public V_Homepage()
        {
            InitializeComponent();
            this.Load += V_Homepage_Load;
        }

        // Event yang dipanggil saat UserControl dimuat
        private void V_Homepage_Load(object sender, EventArgs e)
        {
            try
            {
                int totalPasien = C_Homepage.TotalPasien();
                label_jumlahpasien.Text = $"{totalPasien}";

                int totalRekamMedis = C_Homepage.TotalRekamMedis();
                label_hasilpemeriksaan.Text = $"{totalRekamMedis}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void label_jumlahpasien_Click(object sender, EventArgs e)
        {

        }
    }
}
