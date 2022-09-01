// See https://aka.ms/new-console-template for more inform
List<string> stringList = new List<string>(){ "carro", "casa", "roupa", "avião" };
List<int> intList = new List<int>{ 1, 2, 6, 8, 10, 87, 45 };

List<string> vehicles = new List<string>(){ "carro", "moto", "avião" };

foreach (var item in vehicles)
{
  //  Console.WriteLine(item);
}

// .Add() - Serve para adicionarmos itens da lista.
// .Remove() - Serve para remover um item específico da lista.
// .RemoveAt() - Serve para removermos itens da lista segundo o índice deles.
// .IndexOf - Nos retorna o índice de um objeto na lista.
// .Sort() - Serve para ordenar a nossa lista.

List<string> cars = new (){ "Fusca", "ferrari" };
cars.RemoveAt(0);
cars.ForEach(car => {
    Console.WriteLine(car);
});

 SortedList<string, string> openWith =
new ();

;

openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");

          foreach(var i in openWith) {
   Console.WriteLine(i);
          };
public class Garage
{
    public List<string> Vehicles { get; set; } = new List<string>();

    public int AddVehicle(string vehicle)
    {
        Vehicles.Add(vehicle);

        return Vehicles.Count;
    }

    public int RemoveVehicle(string vehicle)
    {
        Vehicles.Remove(vehicle);

        return Vehicles.Count;
    }

    public int FindVehiclePosition(string vehicle)
    {
        return Vehicles.IndexOf(vehicle);
    }
}
         