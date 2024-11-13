using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PBO_B08.App.Model
{
    internal class M_Akun
    {
        public M_Akun(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public int idAkun { get; set; }
        public string Nama { get; set; }
        public string Email {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
