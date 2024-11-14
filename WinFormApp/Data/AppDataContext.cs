using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WinFormApp.Models;

namespace WinFormApp.Data
{
    internal class AppDataContext : DbContext
    {
        // Metoda slouzi k nastaveni pripojeni k SQL Serveru pomoci connection string
        // uchovaneho v App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AppDatabase"].ConnectionString);
        }

        // Nastaveni reprezentace tabulek dle modelu
        public DbSet<Person> People { get; set; }
        public DbSet<Company> Companies { get; set; }

        // Konfigurace modelu - unikatnost dat, data nesmeji byt duplicitni
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasIndex(p => p.Email).IsUnique();
            modelBuilder.Entity<Person>().HasIndex(p => p.PhoneNumber).IsUnique();
            modelBuilder.Entity<Company>().HasIndex(p => p.Email).IsUnique();
            modelBuilder.Entity<Company>().HasIndex(p => p.PhoneNumber).IsUnique();
        }
    }
}
