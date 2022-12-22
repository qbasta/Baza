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
    
        public DbSet<Aktualnosci> Aktualnoscis { get; set; }
        public DbSet<Burmistrz> Burmistrzs { get; set; }
        public DbSet<Miejscowosc> Miejscowoscs { get; set; }
   
        public DbSet<UrzadMiastaInfo> UrzadMiastaInfos { get; set; }
        public DbSet<UslugiPubliczne> UslugiPublicznes  { get; set; }
        public DbSet<Usterki> Usterkis { get; set; }
        public DbSet<Ogloszenia> Ogloszenias { get; set; }
    }
}