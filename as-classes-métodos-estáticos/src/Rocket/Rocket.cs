namespace Rocket;


public class Rocket
{
 
 public int _fuel;
 public int _maxFuel = 5000;

 public int FuelAsPorcentage 
 {
    get { return _fuel * 100 / _maxFuel; }
    set { if( value > 100 || value < 0 ) {
        throw new ArgumentOutOfRangeException();
        }
        _fuel = (value * _maxFuel) / 100;
    }
 }

}