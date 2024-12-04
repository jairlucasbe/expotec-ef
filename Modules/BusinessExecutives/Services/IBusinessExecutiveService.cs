using expotec_ef.Modules.BusinessExecutives.Models.Dtos;
using expotec_ef.Modules.BusinessExecutives.Models;

namespace expotec_ef.Modules.BusinessExecutives.Services
{
    public interface IBusinessExecutiveService
    {
        Task<IEnumerable<BusinessExecutive>> GetAllAsync();
        Task<BusinessExecutive> GetByIdAsync(string id);
        Task<BusinessExecutive> CreateAsync(CreateBusinessExecutiveDto dto);
        Task<BusinessExecutive> UpdateAsync(string id, UpdateBusinessExecutiveDto dto);
        Task<BusinessExecutive> DeleteAsync(string id);
    }
}
