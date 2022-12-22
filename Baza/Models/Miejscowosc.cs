using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Miejscowosc
    {

        [Key]
        public int idMiejscowosci { get; set; }

        [Display(Name = "Nazwa")]
        [Required]
        public string nazwa { get; set; }

        [Display(Name = "Liczba mieszkańców")]
        [Required]
        public int liczbaMieszkancow { get; set; }

        [Display(Name = "Powierzchnia")]
        [Required]
        public int powierzchnia { get; set; }

        public virtual Burmistrz Burmitrz { get; set; }
        public virtual UrzadMiastaInfo UrzadMiasta { get; set; }
        public virtual ICollection<Zabytek> Zabytki { get; set; }
        public virtual ICollection<MiejscowoscOgloszenia> MiejscowoscOgloszenia { get; set; }
        public virtual ICollection<MiejscowoscUsterki> MiejscowoscAktualnosci { get; set; }
        public virtual ICollection<MiejscowoscUslugi> MiejscowoscUslugi { get; set; }
    }
}
