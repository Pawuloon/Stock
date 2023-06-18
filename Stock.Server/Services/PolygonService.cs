using System.Text.Json;

namespace Stock.Server.Services;

public class PolygonService : IPolygonService
{

  
    private readonly HttpClient _httpClient;

    public PolygonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Company> GetCompanyAsync(string symbol)
    {
        var apiKey = "wLLws_fgOA0rv8cB_toGfvdBCpcd1yCj";
        var url = $"https://api.polygon.io/v1/meta/symbols/{symbol.ToUpper()}/company?apiKey={apiKey}";
        var response = await _httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        var content = await response.Content.ReadAsStringAsync();
        var companyData = JsonSerializer.Deserialize<Company>(content);
        
        var company = new Company
        {
            Name = companyData.Name,
            Symbol = companyData.Symbol,
            Exchange = companyData.Exchange,
            Industry = companyData.Industry,
            ListDate = companyData.ListDate,
            Cik = companyData.Cik,
            Country = companyData.Country,
            Bloomberg = companyData.Bloomberg,
            Figi = companyData.Figi,
            Lei = companyData.Lei,
            Sic = companyData.Sic,
            Sector = companyData.Sector,
            MarketCap = companyData.MarketCap,
            Employees = companyData.Employees,
            Phone = companyData.Phone,
            Ceo = companyData.Ceo,
            Url = companyData.Url,
            Description = companyData.Description,
            ExchangeSymbol = companyData.ExchangeSymbol,
            HqAddress = companyData.HqAddress,
            HqState = companyData.HqState,
            HqCountry = companyData.HqCountry,
            Type = companyData.Type,
            Updated = companyData.Updated,
            Tags = companyData.Tags,
            Similar = companyData.Similar,
            Active = companyData.Active
            
        
        };
        return company;

    }
}