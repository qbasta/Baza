using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class SerwisUsterka
    {
        [ScaffoldColumn(false)]
        [Key]
        public int SerwisUsterkaId { get; set; }
        public int idSerwisu { get; set; }
        public int idUsterki { get; set; }

        public virtual Serwis Serwis { get; set; }
        public virtual Usterki Usterki { get; set; }
    }
}
