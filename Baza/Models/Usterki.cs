using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class Usterki
    {
        [Key]
        public int idUsterki { get; set; }

        [Display(Name = "Rodzaj/typ usterki")]
        [Required]
        public Typ typUsterki { get; set; }


        [Display(Name = "Status")]
        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public string Miejscowosc { get; set; }


        [Display(Name = "Data zgłoszenia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "Godzina i data")]
        public DateTime? dataZgloszenia { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string opis { get; set; }

        /*
        [DataType(DataType.Upload)]
        [Display(Name = "Wyślij plik")]
        public byte[] zdjecie { get; set; }
        */
    }
    public enum Typ { 
    
        hydrauliczne,
        drogowe,
        elektryczne,
        inne
    }
}
