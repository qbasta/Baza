using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Miejscowosc
    {
        [ScaffoldColumn(false)]
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
        public virtual UrzadMiasta UrzadMiasta { get; set; }
        public virtual ICollection<Zabytek> Zabytki { get; set; }
        public virtual ICollection<SerwisMiejscowosc> SerwisMiejscowosc { get; set; }
        public virtual ICollection<MiejscowoscZgloszenie> MiejscowoscZgloszenie { get; set; }
        public virtual ICollection<MiejscowoscAktualnosci> MiejscowoscAktualnosci { get; set; }
        public virtual ICollection<MiejscowoscUslugi> GminaUslugi { get; set; }
    }
}
