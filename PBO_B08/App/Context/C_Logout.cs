using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Windows.Forms;
using PBO_B08.App.Core;

namespace PBO_B08.App.Context
{
    internal class C_logout : DataWrapper
    {
        public static void Logout()
        {
            try
            {
                V_Login v_login = new V_Login();
                v_login.Show();

                foreach (Form form in Application.OpenForms)
                {
                    if (form is not V_Login)
                    {
                        form.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat logout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
