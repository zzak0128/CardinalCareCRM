using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardinalCare.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Model.Services
{
    public class ChildServices
    {
        private ChildDbContext dbContext;

        public ChildServices(ChildDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        #region GetChildren
        public async Task<List<Child>> GetChildAsync()
        {
            return await dbContext.Children.ToListAsync();
        }
        #endregion


        #region AddChildAsync
        public async Task<Child> AddChildAsync(Child child)
        {
            try
            {
                dbContext.Children.Add(child);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return child;
        }
        #endregion


        #region Update Child
        public async Task<Child> UpdateChildAsync(Child child)
        {
            try
            {
                var productExist = dbContext.Children.FirstOrDefault(c => c.ChildId == child.ChildId);
                if (productExist != null)
                {
                    dbContext.Update(child);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return child;
        }
        #endregion



        #region delete child
        public async Task DeleteChildAsync(Child child)
        {
            try
            {
                dbContext.Children.Remove(child);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
