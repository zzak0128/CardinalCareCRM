using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Infrastructure.Services
{
    public class EnrollmentTypeService
    {
        private readonly ZakOpsDb db;

        public EnrollmentTypeService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<EnrollmentType> AddEnrollmentTypeAsync(EnrollmentType EnrollmentType)
        {
            try
            {
                db.EnrollmentTypes.Add(EnrollmentType);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return EnrollmentType;
        }

        // Read
        public async Task<List<EnrollmentType>> GetEnrollmentTypesAsync()
        {
            return await db.EnrollmentTypes.ToListAsync();
        }

        public async Task<EnrollmentType> GetEnrollmentTypeByIdAsync(int id)
        {
            EnrollmentType output = await db.EnrollmentTypes.FirstOrDefaultAsync(c => c.EnrollmentTypeId == id);
            return output;
        }

        // Update
        public async Task<EnrollmentType> UpdateEnrollmentTypeAsync(EnrollmentType EnrollmentType)
        {
            try
            {
                var EnrollmentTypeExists = await db.EnrollmentTypes.FirstOrDefaultAsync(c => c.EnrollmentTypeId == EnrollmentType.EnrollmentTypeId);
                if (EnrollmentTypeExists != null)
                {
                    db.Update(EnrollmentType);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return EnrollmentType;
        }

        // Delete
        public async Task DeleteEnrollmentTypeAsync(EnrollmentType EnrollmentType)
        {
            try
            {
                var EnrollmentTypeExists = await db.EnrollmentTypes.FirstOrDefaultAsync(c => c.EnrollmentTypeId == EnrollmentType.EnrollmentTypeId);
                if (EnrollmentTypeExists != null)
                {
                    db.EnrollmentTypes.Remove(EnrollmentType);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
