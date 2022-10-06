using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Products
{
    [Key]
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}