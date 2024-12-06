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
    public partial class V_Logout : UserControl
    {

        public event Action OnLogoutConfirmed;

        public V_Logout()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIya_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTidak_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OnLogoutConfirmed?.Invoke();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ((Panel)this.Parent).Parent.Controls["panelOverlay"].Visible = false;
        }
    }
}