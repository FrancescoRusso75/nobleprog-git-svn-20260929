using System.Text.Json;
using Catalog;

var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "appsettings.json"));
var settings = JsonDocument.Parse(json).RootElement.GetProperty("Catalog");

var vatRate = settings.GetProperty("VatRate").GetDecimal();
var dataFile = settings.GetProperty("DataFile").GetString()!;
var currency = settings.GetProperty("Currency").GetString();

var products = new List<Product>
{
    new("P001", "Tastiera", 25.00m, 10),
    new("P002", "Mouse", 12.50m, 3),
};
var calculator = new PriceCalculator(vatRate);

foreach (var product in products)
{
    Console.WriteLine($"{product.Code,-6} {product.Name,-22} {calculator.Gross(product, 1),10:N2} {currency}");
}
