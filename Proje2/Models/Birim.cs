using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }

        public string Ad { get; set; }


        //ilişkilendımek ıcın kullanır
        public List<personel> Personels { get; set; }
    }
}
