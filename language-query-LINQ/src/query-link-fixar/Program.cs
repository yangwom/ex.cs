namespace System.Linq;
// Contém todas as classes, interfaces e enumeradores básicos usados para trabalhar com LINQ.

// Anota aí 🖊: Sempre iremos incluir este namespace em nosso projeto, pois cada consulta feita em LINQ o utiliza como base.

// System.Data.Linq
// As classes neste namespace auxiliam na manipulação de base de dados SQL, independente do banco a ser utilizado.

// System.Linq.Expressions
// Este namespace disponibiliza uma série de utilitários que permitem a criação das condições as quais podemos utilizar no LINQ. É por meio dessas condições que fazemos a manipulação dos dados.

// De olho na dica👀: Um exemplo de expressão pode ser a nossa boa e velha condicional IF 😏

// Agora que já conhecemos as três classes fundamentais do LINQ, podemos começar a incluí-las em nossos projetos.

class Program
{
    static string[] games;
    static string[] actors;
    static void Main()
    {
        // LinqFixar();
        // LinqLambad();
        // Consult();
        // FilteredArtist();
        fruits();
    }

    static void LinqFixar()
    {
        games = new string[] { "Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft" };

        IEnumerable<string> FilteredGames = from game in games
                                            where game.Contains('a')
                                            select game;

        foreach (var result in FilteredGames)
            Console.WriteLine(result);
    }

    static void LinqLambad()
    {
        games = new string[] { "Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft" };
        IEnumerable<string> FilteredGames = Enumerable.Where(games, element => element.Contains('e'));
        foreach (var result in FilteredGames)
            Console.WriteLine($" feito com classe de perfeito  {result}");

    }

    static void Consult()
    {
        actors = new string[] { "Al Pacino", "Samuel L. Jackson", "Robert De Niro", "Leonardo DiCaprio", "Morgan Freeman" };

        var actorList = (from actor in actors
                         select actor).Count();
        Console.WriteLine(actorList);
    }
    internal class Artist
    {
        public string? name { get; set; }
        public int listeners { get; set; }
    }

    static void FilteredArtist()
    {
        Artist[] listArtist = new Artist[]
        {
        new Artist { name = "yang", listeners = 1000 },
        new Artist { name = "Mozart", listeners = 15000 },
        new Artist { name = "Elvis Presley", listeners = 25000 },
        new Artist { name = "Bob Dylan", listeners = 30000 },
        new Artist { name = "Guns N' Roses", listeners = 40000 },
        };

        var filterArtist = from artist in listArtist select artist;
        var filterArtistCount = (from artist in listArtist select artist).Count();
        foreach (var ele in filterArtist)
            Console.WriteLine($"{ele.name} numero total de artista é {filterArtistCount}");
    }

    static void fruits()
    {

        string[] fruits = { "Banana", "Orange", "Apple", "Mango", "Grape" };

        var ordenedFruits = from fruitName
                              in fruits
                            orderby fruitName
                            orderby fruitName.Length
                            select fruitName;
                            foreach(var fruit in ordenedFruits)
        Console.WriteLine(fruit);

        string[] words = { "owner", "report", "warm", "scramble", "party" };

var objWords = from word in words
                select new { word, length = word.Length };
       foreach(var e in objWords)
                Console.WriteLine(objWords);
                
    }

}
