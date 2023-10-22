namespace Postgresql.Domain;

public sealed class Stock
{
    public DateTimeOffset Time { get; set; }

    // [ForeignKey( /* navigation property */ nameof(Company))]
    public string Symbol { get; set; } = "";

    public decimal? Price { get; set; }
    public int? DayVolume { get; set; }
    public Company Company { get; set; } = default!;
}