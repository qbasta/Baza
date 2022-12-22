using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class UrzadMiastaInfo
    {
        [Key]
        [ForeignKey("Miejscowosc")]
        public int id_Miejscowosci { get; set; }

        [Phone]
        [RegularExpression(@"([\+]){0,1}([0-9]{2})?[\-\s]?[-]?([0-9]{3})\-?[-\s]?([0-9]{3})[-\s]\-?([0-9]{3})$",
                            ErrorMessage = "Numer musi być zapisany w formacie 123-123-123")]
        [Display(Name = "Numer kontaktowy")]
        [Required]
        public string telefonKontaktowy { get; set; }

        [Display(Name = "Godziny otwarcia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH/mm}")]
        [Required]
        public DateTime godzinyOtwarcia { get; set; }

        [Display(Name = "Godziny zamknięcia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH/mm}")]
        [Required]
        public DateTime godzinyZamknięcia { get; set; }

        [Display(Name = "Adres")]
        [Required]
        public string adres { get; set; }
        public virtual Miejscowosc Miejscowosc { get; set; }
    }
}
