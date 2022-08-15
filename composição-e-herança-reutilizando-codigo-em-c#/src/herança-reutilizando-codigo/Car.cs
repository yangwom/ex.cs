namespace Vehicle;


class Car 
{

    public double TopSpeed { get; set; }
    public int Weight { get; set; }
    public bool IsAutomatic { get; set; }
    public int NumberOfSeats { get; set; }

    public Engine Engine { get; set; } = new Engine();

    public void Drive(double distanceKm, double speed)
    {
        if (speed > TopSpeed)
            Console.WriteLine("Your car can't go that fast!");
        else if (!Engine.IsStarted)
            Console.WriteLine("Your car isn't turned on!");
        else
        {
            var time = distanceKm / speed;
            Console.WriteLine($"You arrived in {time} hours.");
        }
    }

   public void StartEngine() => Engine.Start();

    public void StopEngine() => Engine.Stop();
}
