using System.ComponentModel.DataAnnotations;

namespace Stock.Shared.Models;

public class Company
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Ticker { get; set; }
    public string? Logo { get; set; }
    public DateTime? ListDate { get; set; }
    public string? Industry { get; set; }
    public string? Sector { get; set; }
    public decimal? MarketCap { get; set; }
    public string? Country { get; set; }
    public string? Description { get; set; }
    public int? Employees { get; set; }
    public string? Ceo { get; set; }
    public string? Url { get; set; }
    public string? Symbol { get; set; }
    public string? ExchangeSymbol { get; set; }
    public string? HqAddress { get; set; }
    public string? HqState { get; set; }
    public DateTime? Updated { get; set; }
    public bool? Active { get; set; }
    public int? Cik { get; set; }
    public string? Bloomberg { get; set; }
    public int  Lei { get; set; }
    public int Figi { get; set; }
    public string? Tags { get; set; }
    public string? Similar { get; set; }

}