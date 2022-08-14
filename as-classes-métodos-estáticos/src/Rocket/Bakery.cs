namespace Rocket;


public class Bakery
{
  public static Bread FabricateBread(int weight)
    {
        return new Bread
        {
            Weight = weight,
            Type = "White"
        };
    }

    public static Cake FabricateChocolateCake(string size)
    {
        return new Cake
        {
            Size = size,
            Flavour = "Chocolate"
        };
    }
}