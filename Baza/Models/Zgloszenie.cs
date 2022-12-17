using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Zgloszenie 
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idZgloszenia { get; set; }

        [Display(Name = "Status")]
        [Required]
        [DefaultValue("oczekujace")]
        public string status { get; set; }

        [Required]
        public string Miejscowosc { get; set; }

        [Display(Name = "Data zgłoszenia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? dataZgloszenia { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string opis { get; set; }

        [Display(Name = "Typ")]
        [Required]
        public Typ typUsterki { get; set; }

        [Display(Name = "Prześlij plik")]
        public string ImagePath { get; set; }
        [NotMapped]
        //public HttpPostedFileBase ImageFile { get; set; }
        public int idUsterki { get; set; }
      
        public virtual ICollection<MiejscowoscZgloszenie> MiejscowoscZgloszenie { get; set; }
        public virtual Usterki Usterka { get; set; }
    }
}
