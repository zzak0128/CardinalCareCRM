using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class EnrollmentStatusService
    {
        private readonly ZakOpsDb db;

        public EnrollmentStatusService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<EnrollmentStatus> AddEnrollmentStatusAsync(EnrollmentStatus EnrollmentStatus)
        {
            try
            {
                db.Enrollment.Add(EnrollmentStatus);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return EnrollmentStatus;
        }

        // Read
        public async Task<List<EnrollmentStatus>> GetEnrollmentStatussAsync()
        {
            return await db.Enrollment.ToListAsync();
        }

        public async Task<EnrollmentStatus> GetEnrollmentStatusByIdAsync(int id)
        {
            EnrollmentStatus output = await db.Enrollment.FirstOrDefaultAsync(c => c.EnrollmentId == id);
            return output;
        }

        // Update
        public async Task<EnrollmentStatus> UpdateEnrollmentStatusAsync(EnrollmentStatus EnrollmentStatus)
        {
            try
            {
                var EnrollmentStatusExists = await db.Enrollment.FirstOrDefaultAsync(c => c.EnrollmentId == EnrollmentStatus.EnrollmentId);
                if (EnrollmentStatusExists != null)
                {
                    db.Update(EnrollmentStatus);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return EnrollmentStatus;
        }

        // Delete
        public async Task DeleteEnrollmentStatusAsync(EnrollmentStatus EnrollmentStatus)
        {
            try
            {
                var EnrollmentStatusExists = await db.Enrollment.FirstOrDefaultAsync(c => c.EnrollmentId == EnrollmentStatus.EnrollmentId);
                if (EnrollmentStatusExists != null)
                {
                    db.Enrollment.Remove(EnrollmentStatus);
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
