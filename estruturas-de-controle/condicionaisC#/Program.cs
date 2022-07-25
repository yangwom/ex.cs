namespace condicionais;


public class Program
{
    public static int radius;

    public static int number;
    public static void Main()
    {
        Console.WriteLine("Informe o raio de um círculo (deve ser um número inteiro)");
        string response = Console.ReadLine()!;
        /* int32.tryParse recebe o primeiro parametro que será a string que tem um inteiro a ser convertido 
        e segundo  vai retornar o inteiro convertido de response, se for passado um inteiro no 
        parametro o metódo retornara true, caso ao contrario  false.
        */


        var canConvert = int.TryParse(response, out radius);

        if (canConvert)
        {
            const double pi = 3.14159;

            double circumference = pi * (2 * radius);

            Console.WriteLine("A circunferência de um circulo com raio " + radius + " é igual a " + circumference);
        }
        else
        {
            Console.WriteLine("O texto digitado não é um número inteiro.");
        }
        
        VerifyNumber();

    }
    public static void VerifyNumber()

    {
        Console.WriteLine("digite um numero");

        int isNumber = int.Parse(Console.ReadLine()!);

        if (isNumber > 0)
        {
            Console.WriteLine("maior que zero");
        }
        else
        {
            if (isNumber < 0)

            {
                Console.WriteLine("menor que zero");
            }
            else
            {
                Console.WriteLine("igual a zero");
            }
        }
    }
}



