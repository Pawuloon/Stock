using System.Text.Json.Serialization;

public class Company
{
    [JsonPropertyName("logo")]
    public string Logo { get; set; }

    [JsonPropertyName("listdate")]
    public DateTime ListDate { get; set; }

    [JsonPropertyName("cik")]
    public string Cik { get; set; }

    [JsonPropertyName("bloomberg")]
    public string Bloomberg { get; set; }

    [JsonPropertyName("figi")]
    public string Figi { get; set; }

    [JsonPropertyName("lei")]
    public string Lei { get; set; }

    [JsonPropertyName("sic")]
    public int Sic { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("industry")]
    public string Industry { get; set; }

    [JsonPropertyName("sector")]
    public string Sector { get; set; }

    [JsonPropertyName("marketcap")]
    public decimal MarketCap { get; set; }

    [JsonPropertyName("employees")]
    public int Employees { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("ceo")]
    public string Ceo { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("exchange")]
    public string Exchange { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; }

   

    [JsonPropertyName("hq_address")]
    public string HqAddress { get; set; }

    [JsonPropertyName("hq_state")]
    public string HqState { get; set; }

    [JsonPropertyName("hq_country")]
    public string HqCountry { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }
}
