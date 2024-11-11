using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores {  get; set; }
        public DbSet<Sale> Sales {  get; set; }
        public DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ASUS\SQLEXPRESS;Database=SalesDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.ProductId);
                entity.Property(p => p.Name).HasMaxLength(50).IsUnicode(true);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(s => s.Name).HasMaxLength(80).IsUnicode(true);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(p => p.CustomerId);
                entity.Property(s => s.Name).HasMaxLength(100).IsUnicode(true);
                entity.Property(s => s.Email).HasMaxLength(80).IsUnicode(false);
            });
        }
    }

}
