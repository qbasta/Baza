using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Web;
using System;
using System.Collections.Generic;

namespace Baza.Models
{
    public class Aktualnosci
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Musisz wprowadzić nazwę")]
        [StringLength(50)]
        public string Title { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Wyślij plik")]
        public byte[] zdjecie { get; set; }


        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Musisz podać opis")]
        public string Description { get; set; }

        [Display(Name = "Data dodania")]
        public DateTime? Date { get; set; } = DateTime.Now;
    }
}

