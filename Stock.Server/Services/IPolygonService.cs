using Stock.Shared.Models;

namespace Stock.Server.Services;

public interface IPolygonService
{
    Task<Company> GetCompanyAsync(string symbol);
}