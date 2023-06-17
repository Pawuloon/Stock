using System.Text.Json;
using Stock.Shared.Models;

namespace Stock.Server.Services;

public class PolygonService : IPolygonService
{

    private const string BaseUrl = "https://api.polygon.io/v1/meta/symbols/";

    public async Task<Company> GetCompanyAsync(string symbol)
    {
        var apiKey = "wLLws_fgOA0rv8cB_toGfvdBCpcd1yCj";
        var url = $"{BaseUrl}{symbol}/company?apiKey={apiKey}";
        using (HttpClient client = new())
        {
            var response = await client.GetAsync(url);
            if (!response.IsSuccessStatusCode) 
            {
                return new Company();
            }

            var content = await response.Content.ReadAsStringAsync();
            var company = JsonSerializer.Deserialize<Company>(content);
            return company;
        }
    }
}