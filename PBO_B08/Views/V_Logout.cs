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
    public partial class V_Logout : Form
    {
        public V_Logout()
        {
            InitializeComponent();
        }

        private void btnTidak_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            C_logout.Logout();
        }
    }
}
