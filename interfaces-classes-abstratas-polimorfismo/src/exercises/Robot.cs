

public class Robot : ICloneable 
{
  public bool HumanAffection { get; } = true;
    public int ProcessingPower { get; set; }
    public int BatteryCapacity { get; set; }

    public object Clone()
    {
        return new Robot
        {
            ProcessingPower = ProcessingPower,
            BatteryCapacity = BatteryCapacity
        };
    }
}