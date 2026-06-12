namespace Catalog;

public record Discount(decimal Percentage)
{
    public decimal Apply(decimal price) => price * (1 - Percentage / 100m);
}
