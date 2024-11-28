using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Model
{
    internal class M_Pemeriksaan
    {
        [Key]
        public int idRekam { get; set; }
        [ForeignKey("M_Dokter")]
        public int idDokter { get; set; }
        [ForeignKey("M_Pasien")]
        public int idPasien { get; set; }
        [Required]
        public DateOnly tanggalPemeriksaan { get; set; }
        [Required]
        public string hasilPemeriksaan { get; set; }
        [Required]
        public string diagnosis { get; set; }
        [Required]
        public string obat { get; set; }
    }
}
