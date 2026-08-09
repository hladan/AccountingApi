using Accounting.Api.DTOs;
using Accounting.Api.Models;


namespace Accounting.Api.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<List<CompanyDto>> GetAllDtoAsync();
    }
}
