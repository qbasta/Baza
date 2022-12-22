using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Ogloszenia 
    {
        [Key]
        public int idOgloszenia { get; set; }

        [Display(Name = "Status")]
        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string Miejscowosc { get; set; }

        [Display(Name = "Data zgłoszenia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "Godzina i data")]
        public DateTime? dataZgloszenia { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string opis { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Wyślij plik")]
        public byte[] zdjecie { get; set; }

      
        public virtual ICollection<MiejscowoscOgloszenia> MiejscowoscOgloszenia { get; set; }
        public virtual Usterki Usterka { get; set; }
    }

 
}
