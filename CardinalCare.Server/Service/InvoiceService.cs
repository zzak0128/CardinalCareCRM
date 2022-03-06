using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Model;
using CardinalCare.Server.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Server.Service
{
    public class InvoiceService
    {
        private readonly ZakOpsDb db;

        public InvoiceService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<Invoice> AddInvoiceAsync(Invoice Invoice)
        {
            try
            {
                db.Invoices.Add(Invoice);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return Invoice;
        }

        // Read
        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            return await db.Invoices.ToListAsync();
        }

        public async Task<Invoice> GetInvoiceByIdAsync(int id)
        {
            Invoice output = await db.Invoices.FirstOrDefaultAsync(c => c.InvoiceId == id);
            return output;
        }

        // Update
        public async Task<Invoice> UpdateInvoiceAsync(Invoice Invoice)
        {
            try
            {
                var InvoiceExists = await db.Invoices.FirstOrDefaultAsync(c => c.InvoiceId == Invoice.InvoiceId);
                if (InvoiceExists != null)
                {
                    db.Update(Invoice);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return Invoice;
        }

        // Delete
        public async Task DeleteInvoiceAsync(Invoice Invoice)
        {
            try
            {
                var InvoiceExists = await db.Invoices.FirstOrDefaultAsync(c => c.InvoiceId == Invoice.InvoiceId);
                if (InvoiceExists != null)
                {
                    db.Invoices.Remove(Invoice);
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
