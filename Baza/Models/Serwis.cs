using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Serwis
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idSerwisu { get; set; }

        [Display(Name = "Nazwa")]
        [Required]
        public string nazwa { get; set; }

        [Display(Name = "Adres")]
        [Required]
        public string adres { get; set; }

        [Display(Name = "NIP")]
        [Required]
        public int NIP { get; set; }

        public virtual ICollection<SerwisMiejscowosc> SerwisMiejscowosc { get; set; }
        public virtual ICollection<SerwisUsterka> SerwisUsterka { get; set; }
    }
}
