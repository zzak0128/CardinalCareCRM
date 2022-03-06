using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class GuardianService
    {
        private readonly ZakOpsDb db;

        public GuardianService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<Guardian> AddGuardianAsync(Guardian Guardian)
        {
            try
            {
                db.Guardians.Add(Guardian);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Guardian;
        }

        // Read
        public async Task<List<Guardian>> GetGuardiansAsync()
        {
            return await db.Guardians.ToListAsync();
        }

        public async Task<Guardian> GetGuardianByIdAsync(int id)
        {
            Guardian output = await db.Guardians.FirstOrDefaultAsync(c => c.GuardianId == id);
            return output;
        }

        // Update
        public async Task<Guardian> UpdateGuardianAsync(Guardian Guardian)
        {
            try
            {
                var GuardianExists = await db.Guardians.FirstOrDefaultAsync(c => c.GuardianId == Guardian.GuardianId);
                if (GuardianExists != null)
                {
                    db.Update(Guardian);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Guardian;
        }

        // Delete
        public async Task DeleteGuardianAsync(Guardian Guardian)
        {
            try
            {
                var GuardianExists = await db.Guardians.FirstOrDefaultAsync(c => c.GuardianId == Guardian.GuardianId);
                if (GuardianExists != null)
                {
                    db.Guardians.Remove(Guardian);
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
