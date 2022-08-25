// See https://aka.ms/new-console-template for more information
using static System.String;
using static System.Console;
//string name = "Preencher o nome";     

/*
funções mais utilizada para manipulação de string
Concat()

Split()

IndexOf()

Contains()

Join()
*/

string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
int age = 23;
// concat
string concatResult1 = Concat("oi tudo bem ? ", "meu nome é yang ", "tenho ", age + " anos" );

string concatResult = Concat(textOne, textTwo, textThree);
WriteLine(concatResult1);  
WriteLine(concatResult);  

string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
// Split vai separar em um array o caracteres, se o parametro for vazio ele
// ele vai separar pelos espaços mas voce definir os o separador escolhendo
//algum caracter ex: ';' esse seria o ponto de partidada
 string[] ArraysEmail = emails.Split(';');
 foreach(var element in ArraysEmail)
WriteLine(element);
WriteLine(ArraysEmail[1]);
WriteLine(ArraysEmail[2]);
// indexOf
// achando o caractere pelo indice
// se ele não encontrar ele retorna -1
// o sengundo parametro serve de qual index que vai começar a busca
// se não existir o index vai lançar uma exeção do tipo ArgumentOutOfRangeException
string trybe = "Trybee";
int index = trybe.IndexOf("e", 6);
WriteLine(index);

List<string> languages = new List<string> 
{
 "c#",
 "java",
 "javascript",
 "python"
};
// o contains vai verificar se existi algo numa coleção ou numa string retornando true ou false
bool Exists = languages.Contains("c#");
WriteLine(Exists);

IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
// o primeiro parametro separador e o segundo é a coleção ex: 
// ele vai pegar um array ou uma frase e se vc definiu uma virgura ele vai pegar cada elemento
// e vai separar por virgula
 string arrayNumberString = Join(" , ", listNumbers);
 WriteLine(arrayNumberString);

// interpolação de string
string textString = "string";
string text = $"Isso é uma {textString}";

WriteLine(text);

string domain = "https://www.betrybe.com";
string path = "/empresas-parceiras";
string url = Concat(domain, path);
WriteLine(url); 

string textx = "Eu aprendi a lidar com as propriedades e funções da classe String na Trybe!";
int indexx = textx.IndexOf("p", 20);
WriteLine(indexx);

List<string> animals = new List<string> 
{
  "Cachorro",
  "Gato",
  "Coelho",
  "Pato"
};

WriteLine(animals.Contains("Cachorro"));
WriteLine(animals.Contains("gato"));
WriteLine(animals.Contains("Girafa"));




