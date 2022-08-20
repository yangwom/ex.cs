namespace inter;
public abstract class Animal
{
    public int Age { get; set; }
    public abstract string EatingHabits { get; set; }
    public abstract string Habitat { get; set; }

    public abstract void Feed();
    public abstract void Move();

    public virtual void Sleep()
    {
        Console.WriteLine("Zzzz");
    }
}
public class tesy : IInterfaceA
{
    public int NumberA { get; set; }
	public void InterfaceA(int number)
    {
        NumberA = number;

    }

}

public abstract class ClassA
{
    public int NumberA { get; set; }
    public ClassA(int number)
    {
        NumberA = number;
    }
	
	   public abstract void SayHello();
}
                
 public class ClassB : ClassA
{
    //public int NumberA { get; set; }
    public ClassB(int number) : base(number)
    {
        // NumberA = number;
    }
	
	   public override void SayHello() {
        Console.WriteLine("hello");
       }
}               