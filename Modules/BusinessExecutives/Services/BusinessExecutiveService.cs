using expotec_ef.Data;
using expotec_ef.Modules.BusinessExecutives.Models;
using expotec_ef.Modules.BusinessExecutives.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace expotec_ef.Modules.BusinessExecutives.Services
{
    public class BusinessExecutiveService : IBusinessExecutiveService
    {
        private readonly ApplicationDbContext _context;

        public BusinessExecutiveService(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<BusinessExecutive>> GetAllAsync()
        {
            return await _context.BusinessExecutives.ToListAsync();
        }

        public async Task<BusinessExecutive> CreateAsync(CreateBusinessExecutiveDto dto)
        {
            var businessExecutive = new BusinessExecutive
            {
                Name = dto.Name,
                Dni = dto.Dni,
                Type = dto.Type ?? null,
                PartnerId = dto.PartnerId ?? null
            };
            _context.BusinessExecutives.Add(businessExecutive);
            await _context.SaveChangesAsync();
            return businessExecutive;
        }

        public async Task<BusinessExecutive> DeleteAsync(string id)
        {
            var businessExecutive = await _context.BusinessExecutives.FindAsync(id);
            if (businessExecutive == null)
            {
                throw new KeyNotFoundException("Business Executive not found.");
            }

            _context.BusinessExecutives.Remove(businessExecutive);
            await _context.SaveChangesAsync();
            return businessExecutive;
        }

        public async Task<BusinessExecutive> GetByIdAsync(string id)
        {
            var businessExecutive = await _context.BusinessExecutives
                .FirstOrDefaultAsync(be => be.Id == id);

            if (businessExecutive == null)
            {
                throw new KeyNotFoundException("Business Executive not found.");
            }

            return businessExecutive;
        }

        public async Task<BusinessExecutive> UpdateAsync(string id, UpdateBusinessExecutiveDto dto)
        {
            var businessExecutive = await _context.BusinessExecutives.FindAsync(id);
            if (businessExecutive == null)
            {
                throw new KeyNotFoundException("Business Executive not found.");
            }

            // Update the properties of the existing business executive
            businessExecutive.Name = dto.Name ?? businessExecutive.Name;
            businessExecutive.Dni = dto.Dni ?? businessExecutive.Dni;
            businessExecutive.Type = dto.Type ?? businessExecutive.Type;
            businessExecutive.PartnerId = dto.PartnerId ?? businessExecutive.PartnerId;

            _context.BusinessExecutives.Update(businessExecutive);
            await _context.SaveChangesAsync();
            return businessExecutive;
        }
    }
}
