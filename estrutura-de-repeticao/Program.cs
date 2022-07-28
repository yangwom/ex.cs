// See https://aka.ms/new-console-template for more information


public static class Program
{

    static void Main()
    // enquanto a expressão  for verdadeira ele ira executar
    {
        // o while vai testar a variavel count antes de  executar o 
        // bloco quando for igual 10 nesse caso vai retornar false e o
        // while vai parar de rodar

        // var count = 0;
        // while (count < 10)
        // {
        //     Console.WriteLine("count " + count);
        //     count++;

        // }

        /*
           o do while vai rodar o codigo primeiro e depois vai verifcar
           se a expressão é verdadeira se sim  ele volta no começo ou se
           ele vai rodar pelo menos uma vez
        */

//  var count = 0;
// do
// {
//     Console.WriteLine("count " + count);
//     count++;
// }
// while (count < 100);

/*
no c# quando for so uma linha de codigo não é obrigatorio usar chaves
*/

// for (int count = 0; count < 1000; count++)
//    Console.WriteLine("numero: " + count);

int[] numbers = new int[] { 1, 2, 3, 4 };

var sum = 0;

foreach (var number in numbers) {
   if(number < 3) {
     Console.WriteLine(sum += number);
   }
}

int[] votes = new int[] { 1, 3, 5, 4, 1, 3, 1, 2};
var count = 0;
foreach (var vote in votes)
{                    
  // continue vai saltar os numeros > que trest e vai contabilzar o restante
    if (vote > 3)
        continue;
    count++;    
}  


Console.WriteLine(count + " votos válidos");

 IndexOf(new int[]{5, 6, 7}, 6);
}

  public static int CountOf(int[] numbers, int value)
    {     
        var count = 0;

        foreach(var number in numbers)   
        {
            if(number == value) count++;
        }
          
        return count;

  
    }

     public static int IndexOf(int[] numbers, int value)
    {     
      
        var position = -1;

        for(int i= 0; i < numbers.Length; i++)
        {        
          Console.WriteLine(numbers.Length + " eu sou o Length");
            if(numbers[i] == value)
            {
                position = i;
                break;
            }   

                  for (int counta = 0; counta < 10; counta++)
{
    if(counta == 5)
        break;

    Console.Write(counta + " kkk");
    
}     
        }
        
        return position;
    }

 


  
    }

