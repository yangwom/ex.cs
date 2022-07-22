namespace Enum;


public class testenum 
{
 
static void Main() 
{
test();
}
enum CardinalPoints
{
    Norte,
    Sul,
    Leste,
    Oeste
};
//Utilizando um enum

public static void test() {
CardinalPoints direction = CardinalPoints.Norte;
 Console.WriteLine("Ponto Cardeal: "+direction);
}

}