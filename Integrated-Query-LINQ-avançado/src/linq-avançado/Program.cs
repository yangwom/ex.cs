// See https://aka.ms/new-console-template for more information
using static System.Console;
class State
{
    public string Name { get; set; } = "";
    public string Abbreviation { get; set; } = "";
    public string Region { get; set; } = "";
}

class City
{
    public string Name { get; set; } = "";
    public string StateAbbreviation { get; set; } = "";
}

class Program
{

    static void Main()
    {
        State[] states = {
            new State { Name = "Acre", Abbreviation = "AC", Region = "Norte" },
    new State { Name = "Alagoas", Abbreviation = "AL", Region = "Nordeste" },
    // [...]
    new State { Name = "Pará", Abbreviation = "PA", Region = "Norte" },
    new State { Name = "Paraíba", Abbreviation = "PB", Region = "Nordeste" },
   };

   City[] cities = {
    new City { Name="Belém", StateAbbreviation="PA" },
    new City { Name="Rio Branco", StateAbbreviation="AC" },
    new City { Name="Maceió", StateAbbreviation="AL" },
    // [...]
};

var northEastStates = from state in states
where state.Region == "Nordeste"
from city in cities 
where city.StateAbbreviation == state.Abbreviation
where city.Name.StartsWith("B")
select city;

foreach(var result in northEastStates)

WriteLine(result);

}
}