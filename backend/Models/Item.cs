namespace backend.Models;

public class Item
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string Collection { get; set; } = string.Empty;

    public string Image { get; set; } = string.Empty;

    public decimal Price { get; set; }
}

