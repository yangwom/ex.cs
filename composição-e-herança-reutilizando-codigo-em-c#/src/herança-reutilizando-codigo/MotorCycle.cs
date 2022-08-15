namespace Vehicle;


class MotorCycle 
{
      public double TopSpeed { get; set; }
    public int Weight { get; set; }
    public bool CanDoWheelies { get; set; }
    public Engine Engine { get; set; } = new Engine();
    
    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your bike can't go that fast!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your bike isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

    public void DoWheelie()
    {
        if (!CanDoWheelies)
            Console.WriteLine("Your bike can't do wheelies!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your bike isn't turned on!");
        else
            Console.WriteLine("Your bike is doing a wheelie!");
    }

    public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}