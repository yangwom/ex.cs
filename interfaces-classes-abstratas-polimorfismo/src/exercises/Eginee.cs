using  static System.Console;

namespace inter;

public class Engine : IStartable, IStoppable
{
   public void Start() => WriteLine("start");

   public void Stop() => WriteLine("stop");
}