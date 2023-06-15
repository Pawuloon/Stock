namespace Stock.Shared.Models;

public class PriceCollection
{
    public int Id { get; set; }
    public string? Ticker { get; set; }
    public int? QueryCount { get; set; }
    public string? Results { get; set; }
    public int? Adjusted { get; set; }
    public string? Status { get; set; }
    public string? RequestId { get; set; }
    public int? Count { get; set; }
}