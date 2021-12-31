using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models
{
    public class personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        
        public int BirimId { get; set; }
        public Birim birim { get; set; }
    }
}
