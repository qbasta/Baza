using System.ComponentModel.DataAnnotations;

namespace Baza.Models
{
    public class Uzytkownik
    {
        [Key]
        public int UzytkownikId { get; set; }

        public string Rola { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

    }
}
