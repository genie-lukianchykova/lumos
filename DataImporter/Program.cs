using System.Text.Json;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

var connectionString =
    configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string not found.");

var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer(connectionString)
    .Options;

var jsonPath = Path.Combine(AppContext.BaseDirectory, "db.json");

if (!File.Exists(jsonPath))
{
    throw new FileNotFoundException("Import file not found.", jsonPath);
}

var json = await File.ReadAllTextAsync(jsonPath);

using var document = JsonDocument.Parse(json);

if (!document.RootElement.TryGetProperty("items", out var itemsElement))
{
    throw new InvalidOperationException("The JSON file must contain an 'items' array.");
}

var items = itemsElement.Deserialize<List<Item>>(
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    }) ?? throw new InvalidOperationException("Could not read items.");

await using var db = new AppDbContext(options);

if (await db.Items.AnyAsync())
{
    Console.WriteLine("The Items table is not empty. Import cancelled to avoid duplicates.");
    return;
}

// Let SQL Server generate the item IDs.
foreach (var item in items)
{
    item.Id = 0;
}

db.Items.AddRange(items);
await db.SaveChangesAsync();

Console.WriteLine($"Successfully imported {items.Count} items.");
