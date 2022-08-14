namespace Rocket;

public class Bread
{
    string _type = "";

    public int Weight { get; set; }
    public string Type
    {
        get { return _type; }
        set
        {
            if (value != "White" && value != "Wheat")
                throw new ArgumentException("Invalid bread type");

            _type = value;
        }
    }
}