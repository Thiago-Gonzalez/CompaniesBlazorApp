using CompaniesBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CompaniesBlazorApp.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyBlazorAppDbContext _dbContext;
        public CompanyRepository(CompanyBlazorAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Add(Company company)
        {
            await _dbContext.Companies.AddAsync(company);

            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var company = await GetById(id);

            _dbContext.Companies.Remove(company);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Company>> FindAll()
        {
            List<Company> companies = await _dbContext.Companies.ToListAsync();

            return companies;
        }

        public async Task<Company> GetById(Guid id)
        {
            var company = await _dbContext.Companies.FirstOrDefaultAsync(c => c.Id == id);

            return company;
        }

        public async Task Update(Company company)
        {
            _dbContext.Companies.Update(company);

            await _dbContext.SaveChangesAsync();
        }
    }
}