using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Zabytek
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idZabytku { get; set; }

        [Display(Name = "Nazwa")]
        [Required]
        public string nazwa { get; set; }

        [Display(Name = "Typ")]
        [Required]
        public string typ { get; set; }

        public string Wsp_Lat { get; set; }
        public string Wsp_Lng { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string opis { get; set; }
        public int idMiejscowosci { get; set; }
        public virtual Miejscowosc Miejscowosc { get; set; }
    }

}
