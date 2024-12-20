﻿using System;
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
        V_HalRekam v_HalRekam = new V_HalRekam();
        public V_HalUtama()
        {
            InitializeComponent();
            ShowUserControl(new V_Homepage());
        }

        private void V_HalUtama_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHomepage_Click_1(object sender, EventArgs e)
        {
            V_Homepage v_Homepage = new V_Homepage();

            panel1.Controls.Clear();
            panel1.Controls.Add(v_Homepage);
            //V_Homepage.Dock = DockStyle.Fill;
        }

        private void btnPasien_Click(object sender, EventArgs e)
        {
            V_HalPasien v_HalPasien = new V_HalPasien();

            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalPasien);
            v_HalPasien.Dock = DockStyle.Fill;
        }

        private void btnRekam_Click(object sender, EventArgs e)
        {

            V_HalRekam v_HalRekam = new V_HalRekam();               

            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalRekam);
            v_HalRekam.Dock = DockStyle.Fill;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            V_Logout logout = new V_Logout();
            logout.Show();

        }


        private void btnObat_Click(object sender, EventArgs e)
        {
            V_HalObat v_HalObat = new V_HalObat();

            panel1.Controls.Clear();
            panel1.Controls.Add(v_HalObat);
            v_HalObat.Dock = DockStyle.Fill;
        }

        private void LoadUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear(); 
            userControl.Dock = DockStyle.Fill; 
            panelContent.Controls.Add(userControl); 
        }

        public void ShowUserControl(UserControl userControl)
        {
            panelContent.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContent.Controls.Add(userControl);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            V_HalProfil profilForm = new V_HalProfil();


            panel1.Controls.Clear();
            panel1.Controls.Add(profilForm);
            profilForm.Dock = DockStyle.Fill;
        }
    }
}
