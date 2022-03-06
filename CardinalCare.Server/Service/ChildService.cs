using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class ChildService
    {
        private readonly ZakOpsDb db;

        public ChildService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<Child> AddChildAsync(Child child)
        {
            try
            {
                db.Children.Add(child);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return child;
        }

        // Read
        public async Task<List<Child>> GetChildrenListAsync()
        {
            return await db.Children.ToListAsync();
        }

        public async Task<Child> GetChildByIdAsync(int id)
        {
            Child output = await db.Children.FirstOrDefaultAsync(c => c.ChildId == id);
            return output;
        }

        // Update
        public async Task<Child> UpdateChildAsync(Child child)
        {
            try
            {
                var childExists = await db.Children.FirstOrDefaultAsync(c => c.ChildId == child.ChildId);
                if(childExists != null)
                {
                    db.Update(child);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return child;
        }

        // Delete
        public async Task DeleteChildAsync(Child child)
        {
            try
            {
                var childExists = await db.Children.FirstOrDefaultAsync(c => c.ChildId == child.ChildId);
                if (childExists != null)
                {
                    db.Children.Remove(child);
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
