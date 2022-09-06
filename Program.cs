using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using CompaniesBlazorApp.Repository;
using CompaniesBlazorApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddDbContext<CompanyBlazorAppDbContext>(options => options.UseInMemoryDatabase("CompanyDB"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();

await builder.Build().RunAsync();
