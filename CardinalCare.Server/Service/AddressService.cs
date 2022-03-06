using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class AddressService
    {
        private readonly ZakOpsDb db;

        public AddressService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<Address> AddAddressAsync(Address Address)
        {
            try
            {
                db.Addresses.Add(Address);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Address;
        }

        // Read
        public async Task<List<Address>> GetAddressesAsync()
        {
            return await db.Addresses.ToListAsync();
        }

        public async Task<Address> GetAddressByIdAsync(int id)
        {
            Address output = await db.Addresses.FirstOrDefaultAsync(c => c.AddressId == id);
            return output;
        }

        // Update
        public async Task<Address> UpdateAddressAsync(Address Address)
        {
            try
            {
                var AddressExists = await db.Addresses.FirstOrDefaultAsync(c => c.AddressId == Address.AddressId);
                if (AddressExists != null)
                {
                    db.Update(Address);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Address;
        }

        // Delete
        public async Task DeleteAddressAsync(Address Address)
        {
            try
            {
                var AddressExists = await db.Addresses.FirstOrDefaultAsync(c => c.AddressId == Address.AddressId);
                if (AddressExists != null)
                {
                    db.Addresses.Remove(Address);
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
