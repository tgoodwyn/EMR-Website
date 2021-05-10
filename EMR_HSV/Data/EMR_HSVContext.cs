using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMR_HSV.Models;

namespace EMR_HSV.Data
{
    public class EMR_HSVContext : DbContext
    {
        public EMR_HSVContext(DbContextOptions<EMR_HSVContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }

        public DbSet<VisualAcuity> VisualAcuity { get; set; }
        public DbSet<VisualAck> VisualAck { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<OcularExam> OcularExam { get; set; }
        public DbSet<Insurance> Insurance { get; set; }
        public DbSet<Doctor> Doctor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Insurance)
                .WithOne(i => i.Patient)
                .HasForeignKey<Insurance>(b => b.PatientId);
        }

        public DbSet<EMR_HSV.Models.MedicalHistory> MedicalHistory { get; set; }
        public DbSet<EMR_HSV.Models.MedicalString> MedicalString { get; set; }
        public DbSet<EMR_HSV.Models.Prescription> Prescription { get; set; }
    }
}
