// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Declarando uma variável do tipo string ideal para dados literários e frases 
string excerptFromBook = "Ser ou não ser, eis a questão";
Console.WriteLine(excerptFromBook);
//Declarando uma variável float que pode armazenar um valor de ponto flutuante com precisão de até 7 digitos
// O sufixo f informa o compilador que o valor é float
float floatValue = 100.99f;
Console.WriteLine(floatValue);
//Declarando uma variável double que pode armazenar um valor de ponto flutuante com precisão de até 15 digitos
// O sufixo d informa o compilador que o valor é um double
double doubleValue = 100.99d;
Console.WriteLine(doubleValue);
//Declarando uma variável decimal que pode armazenar um valor de ponto flutuante com precisão de até 29 digitos.
// O sufixo M informa o compilador que o valor é um decimal
decimal decimalValue = 100.88M;
Console.WriteLine(decimalValue);

//Declarando uma variável char que pode armazenar um unico caractere.
char letter = 'T'; 
Console.WriteLine(letter);



//Entrada de Dados
// int Age = int.Parse(Console.ReadLine());
// decimal Average = decimal.Parse(Console.ReadLine());
// bool Permission = bool.Parse(Console.ReadLine());
// string Name = Console.ReadLine();

//Exemplo de concatenação de Dados
int Number = 10;
string name = "Trybe";
Console.WriteLine("O valor da variável numero é: "+Number);
Console.WriteLine("Eu sou um estudante " + name +"!");

//ENTRADA DE DADOS
Console.WriteLine("Boas vindas ao programa 'Calcula Lâmpada'!");
Console.WriteLine("Informe o nome do còmodo: ");
string convenient = Console.ReadLine();

Console.WriteLine("Informe em metros a largura deste cômodo: ");
decimal width = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe em metros o comprimento deste cômodo: ");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a potência em watts da lâmpada que será utilizada: ");
int power = int.Parse(Console.ReadLine());

//PROCESSAMENTO
decimal squareMeter = width * length;
decimal quotientX = power / 18;
decimal totalLightBulbs = squareMeter / quotientX;

//SAIDA DE DADOS
Console.WriteLine("Para iluminar o cõmodo: " + convenient + " com " + squareMeter.ToString("N2") + " metros quadrados " + "será necessario a instalação de " + totalLightBulbs.ToString("N2") + " lâmpada(s)");

int a = 1;
//incrementa + 1 ao valor de a
a++; //substitui a instrução a = a + 1 
Console.WriteLine("A = "+a);

int b = 10;
//decrementa o -1 ao valor b
b--; //substitui a instrução b = b - 1
Console.WriteLine("B = " + b);

//incrementa qualquer valor à direita na variável à esquerda
int c = 23;
c += 15; //substitui a instrução c = c + 15 
Console.WriteLine("C = " + c);

//decrementa qualquer valor à direita na variável à esquerda
int d = 100;
d -= 25; //substitui a instrução d = d - 25 
Console.WriteLine("D = " + d);

//incrementa multiplicando qualquer valor à direita na variável à esquerda
int e = 11;
e *= 3; //substitui a instrução e = e * 3 
Console.WriteLine("E = " + e);

//decrementa dividindo qualquer valor à direita na variável à esquerda
decimal f = 11;
f /= 3; //substitui a instrução f = f / 3 
Console.WriteLine("F = " + f.ToString("N2"));

//decrementa com a operação de módulo de qualquer valor à direita na variável à esquerda
decimal g = 11;
g %= 3; //substitui a instrução g = g % 3 
Console.WriteLine("G = " + g.ToString("N2"));

				