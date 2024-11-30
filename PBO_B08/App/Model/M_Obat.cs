using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_B08.App.Model
{
    internal class M_Obat
    {
        [Key]
        public int idObat {  get; set; }
        [Required]
        public int namaObat {  get; set; }
    }
}
