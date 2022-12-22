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
    
        public DbSet<Aktualnosci> Aktualnosci { get; set; }
        public DbSet<Burmistrz> Burmistrz { get; set; }
        public DbSet<Miejscowosc> Miejscowosc { get; set; }
   
        public DbSet<UrzadMiastaInfo> UrzadMiastaInfo { get; set; }
        public DbSet<UslugiPubliczne> UslugiPubliczne  { get; set; }
        public DbSet<Usterki> Usterki { get; set; }
        public DbSet<Ogloszenia> Ogloszenia { get; set; }
    }
}