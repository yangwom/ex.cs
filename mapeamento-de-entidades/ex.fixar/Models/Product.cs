public class Product
{
    public int ProductId { get; private set; }
    public string Name { get; set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }

    // a propriedade abaixo é considerada propriedade de navegação e serve para estabelecer relacionamentos,
    // o Entity Framework entende dessa forma, pois o tipo Category não é um tipo escalar (tipo primitivo)
    public Category? Category { get; set; }
}