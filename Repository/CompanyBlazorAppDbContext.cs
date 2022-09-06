using CompaniesBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CompaniesBlazorApp.Repository
{
    public class CompanyBlazorAppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }   

        public CompanyBlazorAppDbContext(DbContextOptions<CompanyBlazorAppDbContext> options) : base(options)
        {
        }
    }
}