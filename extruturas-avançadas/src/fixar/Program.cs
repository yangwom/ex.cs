using static System.Console;
namespace fixar {
 public class People 
{
    /*
     se vc levar pro mundo real muito dificilmente uma pessoa mudara de nome mas como uma string
     é do tipo por referencia se vc quiser trocar joão para maria sera alterado pois são do tipo referencia 
      e pode ser amarzenado na memoria
    */
    public string Name;
    static void Main()
    {
   // Criamos uma nova instância de uma classe People
// e igualamos a propriedade Name a "João"
var joao = new People(){ Name = "João" };

// Criamos uma nova variável e igualamos ela a
// variável criada anteriormente
var maria = joao;
// Modificamos apenas a segunda variável com o novo
// valor de Name para Maria
maria.Name = "Maria";

// Imprimimos o valor de Name da primeira variável
// O valor impresso será Maria e não João
WriteLine(joao.Name);
  var myOrder = new Order();
  
  /*
   É necessário converter para um valor inteiro com (int), 
   pois, caso isso não seja feito, o C# automaticamente invoca o 
   método .ToString() da enum, 
   que retorna uma string com o nome da constante, no caso "Debit" e "Credit".

  */

WriteLine("Crédito: " + (int)PaymentType.Credit);
WriteLine("Débito: " + (int)PaymentType.Debit);

    }

}

struct People2 
{
    /*
    aqui vem a grande diferença do struct ele trabalha com tipo de valor
    e não referencia então se vc atribuir um nome  a uma propriedade sem sera
    aquele nome;
    */
    public string Name;
//     static void Main()
//     {
//    // Criamos uma nova instância de uma classe People
// // e igualamos a propriedade Name a "João"
// var joao = new People(){ Name = "João" };

// // Criamos uma nova variável e igualamos ela a
// // variável criada anteriormente
// var maria = joao;
// // Modificamos apenas a segunda variável com o novo
// // valor de Name para Maria
// maria.Name = "Maria";

// // Imprimimos o valor de Name da primeira variável
// // O valor impresso será Maria e não João
// WriteLine(joao.Name);
//     }

}

enum PaymentType
{
    // Vamos definir as constantes de PaymentType e seus valores
    // Credit tem valor 0
    Credit,

    // Debit tem valor 1
    Debit
}

class Order
{
    public PaymentType PayType;

}

};

