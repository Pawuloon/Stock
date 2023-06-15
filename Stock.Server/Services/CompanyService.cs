using Microsoft.EntityFrameworkCore;
using Stock.Server.Data;
using Stock.Shared.Models;

namespace Stock.Server.Services;

public class CompanyService : ICompanyService
{
    StockDbContext _context;

    public CompanyService(StockDbContext context)
    {
        _context = context;
    }
    
    
    public async Task<List<Company>> GetCompanies()
    {
        return await _context.Companies.OrderBy(c => c.Name).ToListAsync();
    }
    
    public async Task<Company?> GetCompany(int companyId)
    {
        var company = await _context.Companies.FindAsync(companyId);
        if (company == null)
        {
            throw new NullReferenceException();
        }
        return company;
    }
    
    public async Task AddCompany(Company? company)
    {
        if (company != null)
        {
            _context.Companies.Add(company);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new NullReferenceException();
        }
        
    }
    
    public async Task DeleteCompany(int companyId)
    {
        var company = await _context.Companies.FindAsync(companyId);
        if (company != null)
        {
            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new NullReferenceException();
        }
    }
    
    public async Task UpdateCompany(Company company)
    {
        if (company == null)
        {
            throw new NullReferenceException();
        }
        _context.Companies.Update(company);
        await _context.SaveChangesAsync();
    }
    
    public async Task<List<Company>> SearchCompanies(string searchTerm)
    {
        return await _context.Companies.Where(c => c.Name != null && c.Name.Contains(searchTerm)).ToListAsync();
    }
    
    
    
    
}