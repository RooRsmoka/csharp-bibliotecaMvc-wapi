using csharp_bibliotecaMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_bibliotecaMvc.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Libro> Libri { get; set; }
        public DbSet<Autore> Autori { get; set; }
        public DbSet<Prestito> Prestiti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utente>().ToTable("Utenti");
            modelBuilder.Entity<Libro>().ToTable("Libri");
            modelBuilder.Entity<Autore>().ToTable("Autori");
            modelBuilder.Entity<Prestito>().ToTable("Prestiti");
        }
    }
}
