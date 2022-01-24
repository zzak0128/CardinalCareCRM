using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Model.Context
{
    public class ChildDbContext : DbContext
    {
        public ChildDbContext(DbContextOptions<ChildDbContext> options)
            : base(options)
        {
        }

        public DbSet<Child> Children { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>().HasData(GetChildren());
            base.OnModelCreating(modelBuilder);
        }

        #region Populate children list
        private List<Child> GetChildren()
        {
            return new List<Child>
            {
                new Child { ChildId = 0, FirstName = "Kara", MidName = "Lynn", LastName = "Zak", Birthday = DateTime.Now, DietRestrictions = "N/A", Allergies = "N/A" },
                new Child { ChildId = 1, FirstName = "Connor", MidName = "Thomas", LastName = "Zak", Birthday = DateTime.Now, DietRestrictions = "N/A", Allergies = "N/A" },
                new Child { ChildId = 2, FirstName = "Camden", MidName = "Lane", LastName = "Zak", Birthday = DateTime.Now, DietRestrictions = "N/A", Allergies = "N/A" }
            };
        }
        #endregion
    }
}
