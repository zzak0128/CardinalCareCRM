using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CardinalCare.Domain;
using CardinalCare.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CardinalCare.Infrastructure.Services
{
    public class VaccinationFileService
    {
        private readonly ZakOpsDb db;

        public VaccinationFileService(ZakOpsDb db)
        {
            this.db = db;
        }

        // Create
        public async Task<VaccinationFile> AddVaccinationFileAsync(VaccinationFile VaccinationFile)
        {
            try
            {
                db.VaccinationFiles.Add(VaccinationFile);
                await db.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return VaccinationFile;
        }

        // Read
        public async Task<List<VaccinationFile>> GetVaccinationFilesAsync()
        {
            return await db.VaccinationFiles.ToListAsync();
        }

        public async Task<VaccinationFile> GetVaccinationFileByIdAsync(int id)
        {
            VaccinationFile output = await db.VaccinationFiles.FirstOrDefaultAsync(c => c.VaccinationFileId == id);
            return output;
        }

        // Update
        public async Task<VaccinationFile> UpdateVaccinationFileAsync(VaccinationFile VaccinationFile)
        {
            try
            {
                var VaccinationFileExists = await db.VaccinationFiles.FirstOrDefaultAsync(c => c.VaccinationFileId == VaccinationFile.VaccinationFileId);
                if (VaccinationFileExists != null)
                {
                    db.Update(VaccinationFile);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return VaccinationFile;
        }

        // Delete
        public async Task DeleteVaccinationFileAsync(VaccinationFile VaccinationFile)
        {
            try
            {
                var VaccinationFileExists = await db.VaccinationFiles.FirstOrDefaultAsync(c => c.VaccinationFileId == VaccinationFile.VaccinationFileId);
                if (VaccinationFileExists != null)
                {
                    db.VaccinationFiles.Remove(VaccinationFile);
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
