using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Burmistrz
    {
        [Key]
        [ForeignKey("Miejscowosc")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Miejscowosci { get; set; }

        [Display(Name = "Imie")]
        [Required]
        public string imie { get; set; }

        [Display(Name = "Nazwisko")]
        [Required]
        public string nazwisko { get; set; }

        [Display(Name = "Kadencja")]
        [Required]
        public int kadencja { get; set; }

        [Display(Name = "Data pierwszej")]
        [Required]
        public DateTime pierwszaKadencja { get; set; }

        [Display(Name = "Data drugiej")]
        public DateTime? drugaKadencja { get; set; }
        public virtual Miejscowosc Miejscowosc { get; set; }
    }
}
