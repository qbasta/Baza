using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class MiejscowoscUslugi
    {

        [Key]
        public int MiastoUslugiId { get; set; }
        public int idMiejscowosci { get; set; }
        public int idUslugi { get; set; }

        public virtual Miejscowosc Miejscowosc { get; set; }
        public virtual UslugiPubliczne UslugiPubliczne { get; set; }
    }
}
