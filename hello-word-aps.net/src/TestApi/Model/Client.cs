namespace TestApi.Core;

public class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal AccountBalance { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}