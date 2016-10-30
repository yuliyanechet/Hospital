using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("Hospital")
        {
        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Doctor>()
                .HasMany<Patient>(s => s.Patients)
                .WithMany(c => c.Doctors)
                .Map(cs =>
                {
                    cs.MapLeftKey("DoctorRefId");
                    cs.MapRightKey("PatientRefId");
                    cs.ToTable("PatientsDoctors");
                });
        }
    }
}