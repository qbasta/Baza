using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class SerwisMiejscowosc
    {
        
        [Key]
        public int serwisMiejscowoscId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idSerwisu { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual Serwis Serwis { get; set; }
    }
}
