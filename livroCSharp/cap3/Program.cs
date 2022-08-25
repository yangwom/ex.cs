using static System.Console;

namespace livrocsharp 
{
class Program
{
    static void Main(string[]args)
    {
     WriteLine("---- funçãoes de texto");

       string empresa = "  Microsoft Corporation  ";
    WriteLine("TRIM - retira os espaços em branco antes e após a expressão");
    WriteLine($"Nome sem espaços: {empresa.Trim().Length}");

    WriteLine("Length - retorna a qtde de caracteres");
    WriteLine($"Tamanho do texto: {empresa.Length}");
    }
}
};

