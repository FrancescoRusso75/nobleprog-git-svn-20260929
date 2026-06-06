namespace Catalog;

// Compatibilità con il vecchio gestionale (listini pre-2020)
public static class LegacyPricing
{
    public const decimal LegacyDiscount = 0.05m;

    public static decimal ApplyLegacy(decimal price)
    {
        return price * (1 - LegacyDiscount);
    }

    public static bool IsLegacyCode(string code) => code.StartsWith("L");
}
