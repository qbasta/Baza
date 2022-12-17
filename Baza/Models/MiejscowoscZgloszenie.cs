using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class MiejscowoscZgloszenie
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ZgloszenieMiastoId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idZgloszenia { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual Zgloszenie Zgloszenie { get; set; }
    }
}
