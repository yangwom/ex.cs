namespace inter;
public interface IStartable
{
    void Start();
}

public interface IStoppable
{
    int Eita { get; set;}
    void Stop(int number) {
        Eita = number;
    }
}

public interface IPlayer
{
    public void Play(string mediaName);
}

public interface IInterfaceA
{
    int NumberA { get; set; }
     void InterfaceA(int number)
    {
        NumberA = number;
    }
}
                