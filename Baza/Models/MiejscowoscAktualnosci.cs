using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class MiejscowoscAktualnosci
    {
        [ScaffoldColumn(false)]
        [Key]
        public int AktualnosciMiejscowoscId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idAktualnosci { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual Aktualnosci Aktualnosci { get; set; }
    }
}