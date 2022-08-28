using static System.Console;
namespace tipos_avançados;

// criando classes genericas

class Program 
{
    static void Main()
    {
      // declaração do tipo anonymus
    var myAnonymousType = new { Amount = 42, Message = "Olá",  Value = 3.95};

     WriteLine(myAnonymousType.Amount);
     WriteLine(myAnonymousType.Message);
     WriteLine(myAnonymousType.Value);

    }
    public int WordCount(string str)
{
    var splitted = str.Split(new char[] { ' ', '.', '?' },
                        StringSplitOptions.RemoveEmptyEntries);
    return splitted.Length;
}
}




public class GenericList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node Head;

    public GenericList()
    {
        Head = null;
    }

    public void Add(T input)
    {
       

        if (Head == null)
        {
            Head = new Node(input);
            Console.WriteLine("Nó Head criado!");
        }
        else
        {
          //Encontra onde inserir o próximo nó na lista.
            Node lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input); 
        }
    }
}


public class someClass
{
    public static object[] getAllContacts()
    {
        //Cria consulta ao BD
        return new[]
            {
                new{name = "John", number = "1111-1111"},
                new{name = "Steve", number = "2222-2222"},
                new{name = "Clara", number = "3333-3333"},
                new{name = "Ana", number = "4444-4444"}
            };
    }
}


