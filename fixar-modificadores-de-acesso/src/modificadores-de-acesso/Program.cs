using static  System.Console;
// See https://aka.ms/new-console-template for more information
namespace modificadores;
class MyClass
{
    /*
   Um item público no C# significa que qualquer parte do código pode referenciar esse item se estiver no seu escopo. Por exemplo, outras funções ou classes externas podem acessar e modificar o atributo example em qualquer objeto da classe MyClass.

Cuidado: Tipos, atributos e métodos sempre públicos não são uma boa prática no mercado, pois permitem que erros das pessoas desenvolvedoras causem mal funcionamento do sistema ou até traga riscos à segurança dos dados.
    */
    public string example = "uma variável publica."; 
}

public  class MyClass2
 /*
O modificador protected permite o acesso e referência para itens na mesma classe ou em classes herdeiras.
 */

{
    protected readonly string example = "um atributo protegido.";
}

class MyClass3 : MyClass2
{

       static void Main()
    {

     var ex = new MyClass3();
    WriteLine(ex.example);
        
    }
}


