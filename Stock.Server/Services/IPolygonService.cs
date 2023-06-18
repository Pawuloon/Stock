using System.Text.Json;
using Stock.Shared.Models;

namespace Stock.Server.Services;

public interface IPolygonService
{
    Task<Company> GetCompanyAsync(string symbol);
    Task<List<PriceData>> GetDataAsync(string symbol, DateTime from, DateTime to);
}