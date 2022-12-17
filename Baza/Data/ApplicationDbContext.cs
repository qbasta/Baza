using Baza.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Baza.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    
        DbSet<Aktualnosci> Aktualnoscis { get; set; }
        DbSet<Burmistrz> Burmistrzs { get; set; }
        DbSet<Miejscowosc> Miejscowoscs { get; set; }
        DbSet<Serwis> Serwis { get; set; }
        DbSet<UrzadMiasta> UrzadMiastas { get; set; }
        DbSet<UslugiPubliczne> UslugiPublicznes  { get; set; }
        DbSet<Usterki> Usterkis { get; set; }
        DbSet<Zgloszenie> Zgloszenies { get; set; }
    }
}