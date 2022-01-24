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
        private ChildDbContext context;

        public ChildServices(ChildDbContext context)
        {
            this.context = context;
        }


        #region GetChildren
        public async Task<List<Child>> GetChildAsync()
        {
            return await context.Children.ToListAsync();
        }
        #endregion


        #region AddChildAsync
        public async Task<Child> AddChildAsync(Child child)
        {
            try
            {
                context.Children.Add(child);
                await context.SaveChangesAsync();
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
                var productExist = context.Children.FirstOrDefault(c => c.ChildId == child.ChildId);
                if (productExist != null)
                {
                    context.Update(child);
                    await context.SaveChangesAsync();
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
                context.Children.Remove(child);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
