// See https://aka.ms/new-console-template for more information
//Em C#, as exceções podem ser geradas pelo 
//CLR (Common Language Runtime) do .NET ou pelo código do próprio sistema.

namespace Program;
public static class Program
{
    public static void Main()
    {

        var dividendo = Program.DivideNumbers(10, 0);

        Console.WriteLine(dividendo);
    }


    public static int DivideNumbers(int numberOne, int numberTwo)
    {
        try 
        {
            if(numberTwo == 0 ) {
               throw new DivideByZeroException("o valor não pode ser zero");
            }

          return numberOne / numberTwo;
        }

        catch (DivideByZeroException ex)
        {

            Console.WriteLine(ex.Message);
         throw;
        }

        
      
    }
    // tratamento de erro caso for null

//     public bool VerifyProductValidity(int productId)
// {
//   Database db = new Database();

//   try
//   {
//     db.Open();

//     var product = db.GetProduct(productId);
          
//     if (product == null)
//     {
//       throw new NullReferenceException("Produto não encontrado.");
//     }   

//     return product.IsValid; 
//   }
//   catch (NullReferenceException ex)
//   {
//     Console.WriteLine(ex.Message);
//     throw;
//   }
//   finally
//   {
//     db.Close();
//   }  
// }

 
}
