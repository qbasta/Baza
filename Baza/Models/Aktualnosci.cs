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
        [ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Musisz wprowadzić nazwę")]
        [StringLength(50)]
        public string Title { get; set; }

        [Display(Name = "Prześlij plik")]
        public string ImagePath { get; set; }
        [NotMapped]
        //public HttpPostedFileBase ImageFile { get; set; }

        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Musisz podać opis")]
        public string Description { get; set; }

        [Display(Name = "Data wydarzenia")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Date { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<MiejscowoscAktualnosci> MiejscowoscAktualnosci { get; set; }
    }
}

