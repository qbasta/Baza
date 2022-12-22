using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class MiejscowoscOgloszenia
    {
        
        [Key]
        public int OgloszeniaMiejscowoscId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idAktualnosci { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual Ogloszenia Ogloszenia { get; set; }
    }
}