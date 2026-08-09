using Accounting.Api.DTOs;
using Accounting.Api.Repositories;
using Accounting.Api.Models;

namespace Accounting.Api.Services
{
    public class CompanyService
    {
        private readonly ICompanyRepository _repository;
        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<CompanyDto>> GetAll()
        {
            return await _repository.GetAllDtoAsync();
        }
    }
}
