using Accounting.Api.Data;
using Accounting.Api.DTOs;
using Accounting.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Api.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AccountingDbContext _dbContext;
        public CompanyRepository(AccountingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Company>> GetAllAsync()
        {
            return await _dbContext.Companies.ToListAsync();
        }
        public async Task<List<CompanyDto>> GetAllDtoAsync()
        {
            return await _dbContext.Companies
                .Select(c => new CompanyDto
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }
    }
}

