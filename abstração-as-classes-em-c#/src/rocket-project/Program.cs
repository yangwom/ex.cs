namespace Rocket;


class Program {
 
static void Main()
{
    string[] concat;
    var rocket = new Rocket("rtx 5.00000", 20000);
    var rocket2 = new Rocket("rtx 8.00000", 30000);


    concat = new string[] {
     $"A nasa lançou dois foguetes com nome de placa de video são eles {rocket.Name} {rocket.Price}",
     $"{rocket2.Name} {rocket2.Price}"
    };

    foreach(var element in concat)

    Console.WriteLine(element);

   
}


}



