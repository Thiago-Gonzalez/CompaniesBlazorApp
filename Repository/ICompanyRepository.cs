using CompaniesBlazorApp.Models;

namespace CompaniesBlazorApp.Repository
{
    public interface ICompanyRepository
    {
        Task Add(Company company);
        Task Update(Company company);
        Task Delete(Guid id);
        Task<Company> GetById(Guid id);
        Task<List<Company>> FindAll();
    }
}