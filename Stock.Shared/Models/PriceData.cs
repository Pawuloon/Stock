namespace Stock.Shared.Models;

public class PriceData
{
    public int Id { get; set; }
    public string? Symbol {get; set;}
    public bool Status { get; set; }
    public DateTime? From { get; set; }
    public decimal? Open { get; set; }
    public decimal? High { get; set; }
    public decimal? Low { get; set; }
    public decimal? Close { get; set; }
    public int? Volume { get; set; }
    public decimal? AfterHours { get; set; }
    public decimal? PreMarket { get; set; }
}