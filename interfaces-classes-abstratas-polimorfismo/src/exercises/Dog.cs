namespace inter;

public class Dog : Animal, IPlayer
{
    public override string EatingHabits { get; set; } = "Carnivore";
    public override string Habitat { get; set; } = "Human homes";

    public override void Feed()
    {
        Console.WriteLine("Feeding the dog");
    }
    public override void Move()
    {
        Console.WriteLine("Dog is walking");
    }

    public void Bark()
    {
        Console.WriteLine("Woof!");
    }

    public void Play(string name) => Console.WriteLine(name);
}