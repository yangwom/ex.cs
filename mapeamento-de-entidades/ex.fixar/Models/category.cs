public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }

    ICollection<Product>? Products { get; set; }
}