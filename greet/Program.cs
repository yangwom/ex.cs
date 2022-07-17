namespace greet;

public class Ola
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
    }
    public static int Greet(int number, int number1)
    {
      var result = number + number1;

      return result;
    }

    public static string OlaMundo(string name) {
      
      return name;
    }
}




