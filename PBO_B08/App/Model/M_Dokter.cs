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
        [Key]
        public int idDokter { get; set; }
        [Required]
        public string namaDokter { get; set; }
        [Required]
        public string spesialisasi {  get; set; }
        [Required]
        public string jenisKelamin { get; set; }
        [Required]
        public string emailDokter { get; set; }
        [Required]
        public string noTelepon { get; set; }
    }
}
