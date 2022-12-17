using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Baza.Models
{
    public class UslugiPubliczne
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idUslugiPublicznej { get; set; }

        [Display(Name = "Nazwa")]
        public string nazwa { get; set; }

        [Display(Name = "Adres")]
        public string adres { get; set; }

        [Display(Name = "Telefon kontaktowy")]
        public string telefon { get; set; }

        [Display(Name = "Udogodnienia")]
        public string udogodnienia { get; set; }

        public virtual ICollection<MiejscowoscUslugi> MiejscowoscUslugi { get; set; }
    }
}