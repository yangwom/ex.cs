namespace Rocket;


public class Cake 
{
  public string Size { get; set; }
   string _flavour = "";

   public string Flavour 
   {
    get { return _flavour; }
    set { if(value != "Chocolate" || value != "Morango") {
      throw new ArgumentException("Aqui não existe esse sabor");
    }
     _flavour = value;
    }
   }
}