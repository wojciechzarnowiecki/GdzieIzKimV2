using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mapa.Models
{
    public class Kat
    {
        [ScaffoldColumn(false)]
        public int KatId { get; set; }
        [Display(Name = "Kategoria")]
        public string NazwaKat { get; set; }
        [Display(Name = "Opis")]
        public string OpisKat { get; set; }

        public virtual ICollection<m1> Lokalizacja { get; set; }
    }
}