using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PatientMedicament> PatientMedicaments { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ASUS\SQLEXPRESS;Database=HospitalDB_1;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(p => p.FirstName).HasMaxLength(50).IsUnicode(true);
                entity.Property(p => p.LastName).HasMaxLength(50).IsUnicode(true);
                entity.Property(p => p.Address).HasMaxLength(250).IsUnicode(true);
                entity.Property(p => p.Email).HasMaxLength(80).IsUnicode(false);
            });

            modelBuilder.Entity<Visitation>(entity =>
            {
                entity.Property(v => v.Comments).HasMaxLength(250).IsUnicode(true);
            });

            modelBuilder.Entity<Diagnose>(entity =>
            {
                entity.Property(d => d.Name).HasMaxLength(50).IsUnicode(true);
                entity.Property(d => d.Comments).HasMaxLength(250).IsUnicode(true);
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.Property(d => d.Name).HasMaxLength(50).IsUnicode(true);
            });

            modelBuilder.Entity<PatientMedicament>().HasKey(pm => new { pm.PatientId, pm.MedicamentId });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.HasKey(d => d.DoctorId);
                entity.Property(d => d.Name).HasMaxLength(100).IsUnicode(true);
                entity.Property(d => d.Specialization).HasMaxLength(100).IsUnicode(true);
            });


        }
    }
}
