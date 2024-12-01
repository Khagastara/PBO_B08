using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Model
{
    internal class M_Akun
    {
        public M_Akun(string username, string password)
        {
            Username = username;
            Password = password;
        }

        [ForeignKey("M_Dokter")]
        public int idDokter { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
