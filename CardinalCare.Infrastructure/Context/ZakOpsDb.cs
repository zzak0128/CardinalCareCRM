using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Infrastructure.Context
{
    public class ZakOpsDb : DbContext
    {
        public ZakOpsDb(DbContextOptions<ZakOpsDb> options)
            : base(options)
        {
        }

        #region DbSet
        public DbSet<Child> Children { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<VaccinationFile> VaccinationFiles { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<EnrollmentStatus> Enrollment { get; set; }
        public DbSet<EnrollmentType> EnrollmentTypes { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
