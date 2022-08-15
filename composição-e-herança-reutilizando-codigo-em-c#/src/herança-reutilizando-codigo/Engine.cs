namespace Vehicle;


class Engine 
{
  public int Horsepower { get; set; }
    public int Torque { get; set; }
    public int Capacity { get; set; }
    public bool IsStarted { get; set; }

    public void Start()
    {
        if (IsStarted)
            Console.WriteLine("The engine is already started!");
        else
            IsStarted = true;
    }

    public void Stop()
    {
        if (!IsStarted)
            Console.WriteLine("The engine is already stopped!");
        else
            IsStarted = false;
    }
}