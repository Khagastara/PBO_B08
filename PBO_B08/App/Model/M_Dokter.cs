using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PBO_B08.App.Model
{
    internal class M_Dokter
    {
        public M_Dokter(string username, string password)
        {
            Username = username;
            Password = password;
        }
        [Key]
        public int idDokter { get; set; }
        [Required]
        public string namaDokter { get; set; }
        [Required]
        public string emailDokter {  get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
