using PBO_B08.App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Model
{
    internal class M_HasilPemeriksaan
    {
        [Key]
        public int idHasil {  get; set; }
        [ForeignKey("M_Pemeriksaan")]
        public int idRekam {  get; set; }
        [ForeignKey("M_Obat")]
        public int idObat {  get; set; }
        [Required]
        public string hasilPemeriksaan { get; set; }
        [Required]
        public string diagnosis {  get; set; }
    }
}
