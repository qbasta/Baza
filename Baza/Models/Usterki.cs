using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Usterki
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idUsterki { get; set; }

        [Display(Name = "Rodzaj/typ usterki")]
        [Required]
        public Typ typUsterki { get; set; }

        [Required]
        public string Miejscowosc { get; set; }


        [Display(Name = "Data zgłoszenia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? dataZgloszenia { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string opis { get; set; }

        [Display(Name = "Prześlij plik")]
        public string ImagePath { get; set; }
        [NotMapped]
        //public HttpPostedFileBase ImageFile { get; set; }

        public virtual ICollection<SerwisUsterka> SerwisUsterka { get; set; }
        public virtual ICollection<Zgloszenie> Zgloszenie { get; set; }
    }
    public enum Typ
    {
        hydrauliczne,
        drogowe,
        elektryczne,
        inne
    }
}
