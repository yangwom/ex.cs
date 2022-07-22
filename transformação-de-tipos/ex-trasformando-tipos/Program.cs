// A transformação de uma variável de determinado tipo em outro pode ocorrer de diferentes formas. Essas transformações são chamadas de:

// Cast Implícito: ocorrem de maneira mais automática, sem que a pessoa desenvolvedora precise intervir via código.

// Cast Explícito: quando precisamos escrever a transformação e como ela irá ocorrer via código.
public class Program
{

    // aqui é um exemplo de cast Implícito
    // nesse caso é possivel fazer a converão implícita pois o tipo int  amazerna um numero inteiro até 32 bits e o tipo long amarzena um inteiro até 64 bits assim a conversão implícita ocorre sem a perda de informação ex: é mesma coisa que voce pegar uma caixa pequena e colocar na caixa grande
    public static void Main()
    {        
        int someIntNumber = 51;
        long longlNumberCast = someIntNumber;

        Console.WriteLine(longlNumberCast);
        typeConversion();
    }     

    public static void typeConversion() 
    {
        // uma conversão implícita de float para int 
        int intResult = 5/2;

         Console.WriteLine(intResult); // 2
         
    //      no caso a baixo a informação ira se perder pois uma caixa do tipo long é maior que do tipo int logo uma caixa de 64 bits não vai entrar em uma de 32 bits

    //     long someLongNumber = 516144564564654;
    //     int intNumber = (int) someLongNumber;
    //     Console.WriteLine(intNumber);


    //     Cuidado ao usar apenas o cast (int), pois se você perder informação no processo o C# não irá te avisar disso!

    //     Nesse caso  abaixo, o Convert.ToInt32 vai nos avisar de que o número 516144564564654 não cabe em uma variável int, com o seguinte erro:

    //     long someLongNumber = 516144564564654;
    //     int intNumber = Convert.ToInt32(someLongNumber);
    //      Console.WriteLine(intNumber);

    //   Porém, se for possível converter o número, ele vai funcionar sem problemas.
    //     long someLongNumber = 42;
    //     int intNumber = Convert.ToInt32(someLongNumber);

        

    //     Console.WriteLine(intNumber);

        // podemos tambem converter uma string  
        // string someString = "42";
        // Console.WriteLine(someString is string);
        // int convertInt = Convert.ToInt32(someString);
        // se voce esta acstumado com javascript pra voce saber o tipo da string voce usava o typeof aqui no c# é is que significa "é"
        // Console.WriteLine(convertInt is int);

        // agora podemos verificar se realmente é uma string e tomar uma decisão sobre ela

        int yearNumber;
        string yearString = "2022";
         if(yearString is string) {
            yearNumber = Convert.ToInt32(yearString);
            Console.WriteLine(yearNumber);
         } else {
              Console.WriteLine("yearString não é um do tipo string");
         }

       
    }      
}