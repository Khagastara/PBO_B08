using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Model
{
    public class M_Pasien
    {
        [Key]
        public int idPasien { get; set; }
        [Required]
        public string namaPasien { get; set; }
        [Required]
        public string jenisKelamin { get; set; }
        [Required]
        public DateTime tanggalLahir { get; set; }
        [Required]
        public string noTelepon { get; set; }
        [Required]
        public string Alamat { get; set; }
    }
}
