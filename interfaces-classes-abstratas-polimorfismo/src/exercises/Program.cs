namespace inter;
class Program 
{
   static void Main()
   {
    var instance = new Engine();
    var audio = new AudioPlayer();

    instance.Start();
    instance.Stop();
    audio.PlaySong("bem vindo a radio fm");
    audio.PlayPodcast("bem ao nosso podcast");

   }

   public void FeedAnimal(Animal animal)
{
    animal.Feed();
}

public void FeedDog()
{
    var dog = new Dog();
    FeedAnimal(dog);
}
}
