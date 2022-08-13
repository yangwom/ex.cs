namespace Rocket;


class Rocket 
{

    private string name;

    private int fuel;
     
    public decimal price; 
   public string Name { get { return name; } set { name = value; }}
   public int Fuel { get { return fuel; } set { fuel = value; } }
   public decimal Price { get; set; }

    /* O construtor em c# sempre deve ter o mesmo nome da classe
    A palavra-chave public que precede o construtor é necessária 
    caso você queira criar uma instância da classe a partir de outro lugar que não seja a própria classe.
    */

    /*
    diferença entre objetos e classes
    Sob o ponto de vista da programação orientada a objetos (POO), os objetos são definidos como elementos materiais específicos, porém generalizáveis em código. Desse modo, é necessário reiterar que toda instância de uma classe é um objeto, sendo que a classe que lhe deu origem é a respectiva generalização!

Nesse sentido, os objetos serão os elementos que irão interagir no código e vão ser salvos na memória, enquanto as classes são as abstrações que dão origem aos objetos em si.

No caso do C#, o comportamento dos objetos é definido nos métodos das classes, enquanto o seu estado é determinado pelos valores dos seus campos e propriedades.

Os campos normalmente são privados e utilizados para guardar dados que, em regra, devem ser de uso exclusivo dos demais membros da classe.

As propriedades são métodos especiais que funcionam como “campos inteligentes”, permitindo diferentes formas de acessar e modificar os campos de uma classe e, assim como os construtores, tendem a ser públicos, embora isso não seja uma regra.
    */

    public Rocket(string name, int price) {
       Name = name;
       Price = price;
       Fuel = 0;
    }

}
