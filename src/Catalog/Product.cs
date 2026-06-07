namespace Catalog;

public record Product
{
    public string Code { get; }
    public string Name { get; }
    public decimal UnitPrice { get; }
    public int Stock { get; }

    public Product(string code, string name, decimal unitPrice, int stock)
    {
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Il codice è obbligatorio", nameof(code));
        if (unitPrice < 0)
            throw new ArgumentOutOfRangeException(nameof(unitPrice), "Il prezzo non può essere negativo");
        if (stock < 0)
            throw new ArgumentOutOfRangeException(nameof(stock), "La giacenza non può essere negativa");

        Code = code;
        Name = name;
        UnitPrice = unitPrice;
        Stock = stock;
    }
}
