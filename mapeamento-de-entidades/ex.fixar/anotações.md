# Mapeamento de Entidades

## Code First vs DB First

Quando estamos desenvolvendo aplicações .NET utilizando Entity Framework, temos diversas formas de desenvolver e modelar o banco de dados, sendo duas bastante conhecidas: Code-First e DB-First.

## Code-First
No Code-First (Código Primeiro), como o próprio nome indica, o desenvolvimento do código C# vem primeiro, e a partir dele é que o banco de dados é criado.

De forma análoga ocorre no DB-First (banco de dados primeiro).

## DB-First
Adotaremos nessa lição o Code First do Entity Framework.

## Mapeando Entidades

Code-First, código primeiro, então significa partiu mão na massa? 💪 Calma, ainda não! Antes de começarmos a codar, é importante fazer um voo de águia e desenhar tecnicamente o código. Quantos domínios teremos? Quais serão suas propriedades e classes? Essas são perguntas essenciais para guiar o desenvolvimento utilizando Code-First.

Dentro do desenho técnico, ou desenho conceitual do sistema, devemos mapear as entidades e suas propriedades para, quando o Entity Framework Core for criar o banco de dados, ele separá-las por tabelas e colunas. As tabelas serão os nomes das entidades mapeadas, e as colunas serão suas respectivas propriedades.

Utilizando Model para criar tabelas e colunas em um banco de dados
A conexão para criação de tabelas e colunas em um banco de dados de um código baseado em Code-First é realizado utilizando a classe DbSet do namespace. Microsoft.EntityFrameworkCore.

DbSet significa Database Setup, ou Settings, que, numa tradução literal, seria Configuração de Banco de Dados, uma classe genérica DbSet<T>, podendo ser atribuída a ela qualquer classe. Por exemplo, o DbSet de um Model Category seria DbSet<Category>.

O Entity Framework Core, ao criar seu banco de dados, irá mapear o código procurando por DbSets definidos no código.

Assim, vamos criar nosso banco de dados a partir de um Model.

Criamos um projeto do tipo console e criaremos dois Models, um para Category e outro para Product, de forma bem simples para fins didáticos. Nosso foco aqui é criarmos o banco de dados a partir de nosso Model.

Copiar
```c#
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
}
Copiar
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```
Para o Entity Framework Core entender que queremos criar um banco de dados, DataBase ou, simplesmente, DB, precisaremos criar um Model Context que herda algumas características base do DBContext. Para isso, será necessário instalar o pacote Nuget Microsoft.EntityFrameworkCore, executando o seguinte comando:

Copiar
```bash
dotnet add package Microsoft.EntityFrameworkCore
```
E também precisamos instalar os providers adequados com o banco de dados que vamos utilizar. Neste caso, vamos utilizar um banco de dados SQL Server, então vamos instalar o provider do SQL Server com:

Copiar
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
Agora podemos adicionar a instrução using Microsoft.EntityFrameworkCore; na parte superior do código. Será em uma classe de contexto herdando de DbContext que vamos criar nossos DbSets da seguinte forma:

Copiar
```c#
public class MyContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"
                Server=127.0.0.1;
                Database=my_context_db;
                User=SA;
                Password=Password12!;
            ");
        }
    }
}
```
Relembrando🧠: Perceba que a Connection String utilizada é para um servidor SQL Server rodando localmente; se quiser executar esse código na sua máquina, substitua pelos valores adequados ao seu servidor SQL Server.

Dentro do arquivo Program.cs, inclua o seguinte código:

Copiar
using (var db = new MyContext())
{
    db.Database.EnsureCreated();
    // Código executado no banco de dados aqui
}