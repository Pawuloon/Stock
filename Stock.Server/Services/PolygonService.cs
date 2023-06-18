
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
        var retg = JsonSerializer.Deserialize<JsonDocument>(content);
        var comp = new Company()
        {
            Name = retg.RootElement.GetProperty("name").GetString(),
            Symbol = retg.RootElement.GetProperty("symbol").GetString(),
            Logo = retg.RootElement.GetProperty("logo").GetString(),
            ListDate = retg.RootElement.GetProperty("listdate").GetDateTime(),
            Cik = retg.RootElement.GetProperty("cik").GetString(),
            Bloomberg = retg.RootElement.GetProperty("bloomberg").GetString(),
            Sic = retg.RootElement.GetProperty("sic").GetInt32(),
            Country = retg.RootElement.GetProperty("country").GetString(),
            Industry = retg.RootElement.GetProperty("industry").GetString(),
            Sector = retg.RootElement.GetProperty("sector").GetString(),
            MarketCap = retg.RootElement.GetProperty("marketcap").GetDecimal(),
            Employees = retg.RootElement.GetProperty("employees").GetInt32(),
            Phone = retg.RootElement.GetProperty("phone").GetString(),
            Ceo = retg.RootElement.GetProperty("ceo").GetString(),
            Url = retg.RootElement.GetProperty("url").GetString(),
            Description = retg.RootElement.GetProperty("description").GetString(),
            Exchange = retg.RootElement.GetProperty("exchangeSymbol").GetString(),
            Tags = retg.RootElement.GetProperty("tags").EnumerateArray().Select(x => x.GetString()).ToList(),
            HqState = retg.RootElement.GetProperty("hq_state").GetString(),
            HqCountry = retg.RootElement.GetProperty("hq_country").GetString(),
            HqAddress = retg.RootElement.GetProperty("hq_address").GetString(),
            Type = retg.RootElement.GetProperty("type").GetString(),
            Active = retg.RootElement.GetProperty("active").GetBoolean(),
           
        };
        
        
        return comp;

    }
}