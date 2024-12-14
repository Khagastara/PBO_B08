using PBO_B08.App.Core;
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
    public partial class V_HalProfil : UserControl
    {
        public V_HalProfil()
        {
            InitializeComponent();

            lblUsername.Text = UserSession.LoggedInUsername;
            lblPassword.Text = UserSession.LoggedInPassword;
        }

        private void btnEditProfil_Click(object sender, EventArgs e)
        {
            {
                V_EditProfil editprofilForm = new V_EditProfil();

                V_HalUtama.panel1.Controls.Clear();
                V_HalUtama.panel1.Controls.Add(editprofilForm);
                editprofilForm.Dock = DockStyle.Fill;

            }
        }
    }
}
