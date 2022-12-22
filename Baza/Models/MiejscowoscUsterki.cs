using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class MiejscowoscUsterki
    {
        [ScaffoldColumn(false)]
        [Key]
        public int UsterkaMiastoId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idUsterki { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual Usterki Usterki { get; set; }
    }
}
