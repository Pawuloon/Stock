using Stock.Shared.Models;

namespace Stock.Server.Services;

public interface ICompanyService
{
    Task<List<Company>> GetCompanies();
    Task<Company?> GetCompany(int companyId);
    Task AddCompany(Company company);
    
    Task DeleteCompany(int companyId);
    
    Task UpdateCompany(Company company);
    
    Task<List<Company>> SearchCompanies(string searchTerm);

}