
public class program
{

static void Main()
{
using (var db = new MyContext())
{
   db.Database.EnsureCreated();
    Console.WriteLine("Enter a name for a new Category: ");

    string name = Console.ReadLine();
    var category = new Category() { Name = name };
    db.Categories.Add(category);
    db.SaveChanges();
    
   var query =  from data in db.Categories
   orderby data.Name
   select data;

     Console.WriteLine("All categories in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}