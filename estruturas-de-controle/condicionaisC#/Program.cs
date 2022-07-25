namespace condicionais;


public static class Program
{
    public static int radius;

    public static int isNumber;

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

        VerifyNumberIf();
        VerifyNumberSwitchCase();

    }
    public static void VerifyNumberIf()

    {
        Console.WriteLine("digite um numero");

        var isNumber = int.Parse(Console.ReadLine()!);



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

    public static void VerifyNumberSwitchCase()
    {
        Console.WriteLine("digite o numero novamente aqui sera verificado com switch case");
        var isNumber = int.Parse(Console.ReadLine()!);


        switch (isNumber)
        {
            case > 0:
                Console.WriteLine("maior que zero");
                break;

            case < 0:
                Console.WriteLine("menor que zero");
                break;
            default:
                Console.WriteLine("igual a zero");
                break;
        
        }
        /* operadores de comparação no c#  não muda qualse nada do java script
         >	Maior	a > b	Se a for maior que b
        >=	Maior ou igual	a >= b	Se a for maior ou igual a b
        <	Menor	a < b	Se a for menor que b
        <=	Menor ou igual	a <= b	Se a for menor ou igual a b
        ==	Igual	a == b	Se a for igual a b
        !=	Diferente	a != b	Se a for diferente de b
        */
    }

    public static string IdentifyPolygon(int sideCount)
{
    string name;

    switch (sideCount)
    {
        case < 3:
            name = "Não é um polígono";
            break;
        case 3:
            name = "Triângulo";
            break;
        case 4:
            name = "Quadrado";
            break;
        case 5:
            name = "Pentágono";
            break;
        default:
            name = "Polígono não identificado";
            break;
    }
    return name;
}
}



