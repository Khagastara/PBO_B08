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
    public partial class V_HalUtama : Form
    {
        V_HalPasien v_HalPasien = new V_HalPasien();
        public V_HalUtama()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHomepage_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalPasien);
            v_HalPasien.Dock = DockStyle.Fill;
        }

        private void V_HalUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
