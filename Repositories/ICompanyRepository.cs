using Accounting.Api.DTOs;
usin Accounting.Api.Models;


namespace Accounting.Api.Repositories
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<List<CompanyDto>> GetAllDtoAsync();
    }
}
