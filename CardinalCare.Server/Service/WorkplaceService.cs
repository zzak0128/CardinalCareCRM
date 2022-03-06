using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class WorkplaceService
    {
        private readonly ZakOpsDb db;

        public WorkplaceService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<Workplace> AddWorkplaceAsync(Workplace Workplace)
        {
            try
            {
                db.Workplaces.Add(Workplace);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Workplace;
        }

        // Read
        public async Task<List<Workplace>> GetWorkplacesAsync()
        {
            return await db.Workplaces.ToListAsync();
        }

        public async Task<Workplace> GetWorkplaceByIdAsync(int id)
        {
            Workplace output = await db.Workplaces.FirstOrDefaultAsync(c => c.WorkplaceId == id);
            return output;
        }

        // Update
        public async Task<Workplace> UpdateWorkplaceAsync(Workplace Workplace)
        {
            try
            {
                var WorkplaceExists = await db.Workplaces.FirstOrDefaultAsync(c => c.WorkplaceId == Workplace.WorkplaceId);
                if (WorkplaceExists != null)
                {
                    db.Update(Workplace);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Workplace;
        }

        // Delete
        public async Task DeleteWorkplaceAsync(Workplace Workplace)
        {
            try
            {
                var WorkplaceExists = await db.Workplaces.FirstOrDefaultAsync(c => c.WorkplaceId == Workplace.WorkplaceId);
                if (WorkplaceExists != null)
                {
                    db.Workplaces.Remove(Workplace);
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
