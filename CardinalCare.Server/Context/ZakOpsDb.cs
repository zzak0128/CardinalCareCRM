using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Context
{
    public class ZakOpsDb : DbContext
    {
        public ZakOpsDb(DbContextOptions<ZakOpsDb> options)
            : base(options)
        {
        }

        public DbSet<Child> Children { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<VaccinationFile> VaccinationFiles { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<EnrollmentStatus> Enrollment { get; set; }
        public DbSet<EnrollmentType> EnrollmentTypes { get; set; }

        #region DbSet

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
