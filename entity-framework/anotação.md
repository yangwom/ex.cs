# O que é o Entity Framework
Hoje vamos aprender sobre uma das ferramentas mais utilizadas e amadas no universo .NET, o Entity Framework.

# ORM
Quando estamos programando orientado a objetos e precisamos realizar consultas em bancos de dados relacionais, é comum nos depararmos com o problema do mapeamento entre o banco de dados e as classes no código.

É justamente para ajudar nesse processo que utilizamos Object-Relational Mapper (ORM), ou Mapeameto Objeto-Relacional. ORMs são bibliotecas utilizadas para mapear classes e entidades programadas utilizando Programação Orientada a Objetos, POO, para tabelas e colunas em um banco de dados, ou seja, criar uma ponte entre os dados no banco de dados e a linguagem de programação.

Isso cria uma espécie de banco de dados virtual de objetos, uma vez que, utilizando a ORM, é possível acessar, modificar e criar dados utilizando objetos em uma linguagem de programação.

Entity Framework: A ORM do universo .NET
Entity Framework é uma ferramenta de ORM (Object-Relational Mapper) criada pela Microsoft para o .NET. Com essa ferramenta, é possível conectar, criar, modificar, consultar e até mesmo configurar bancos de dados através de código C#.

Vamos pensar, por exemplo, em uma tabela Students em um banco de dados. Essa tabela tem as seguintes colunas:

Id do tipo inteiro
StudentName do tipo varchar
Para realizar uma consulta a essa tabela, seria necessário criar um código SQL semelhante a este:

```sql
SELECT Id, StudentName FROM Students;
```
Essa consulta iria retornar todos os valores disponíveis na tabela, certo?

Para inserir dados nessa tabela, precisaríamos fazer uma consulta como:

```sql
INSERT INTO Students VALUES (5, "João");
```
Agora imagine ter que construir consultas como essa sempre que quiser inserir ou consultar algum dado em um banco de dados. À medida que o número de entidades e tabelas cresce, as consultas ficam cada vez mais complexas, e realizar todo esse processo para cada uma delas deixa de ser uma tarefa simples, principalmente quando precisamos relacionar os dados das tabelas em diversas classes diferentes.

## Instalando Entity Framework Core

Existem dois pacotes diferentes dessa ferramenta: Entity Framework e Entity Framework Core. O Entity Framework não será mais atualizado pela Microsoft, encerrando atualmente na versão 6.0. Por esse motivo, aqui iremos utilizar o Entity Framework Core.

Para instalar o Entity Framework Core em um projeto .NET, execute o comando:

```json
dotnet add package Microsoft.EntityFrameworkCore
```
Para utilizar o Entity Framework com o SQL Server, devemos instalar o seu provedor com o seguinte comando:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
O Entity Framework também conta com um pacote que permite à pessoa desenvolvedora gerar códigos de migração e entidades automaticamente. Este é o Microsoft.EntityFrameworkCore.Design e, para instalá-lo, execute o comando:

Copiar
```bash
dotnet add package Microsoft.EntityFrameworkCore.Design
```
O Entity Framework Core também conta com uma CLI própria, que pode ser usada em conjunto com o pacote de Design para criar códigos C# automaticamente a partir de modelos e bancos de dados.

Para instalar a CLI do Entity Framework Core, execute o comando:

Copiar
dotnet tool install --global dotnet-ef
Agora verificamos se a CLI foi instalada com sucesso com o comando:

Copiar
dotnet ef
Se você vir o unicórnio, significa que a instalação foi um sucesso. 🎉

Copiar

                     _/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\

Entity Framework Core .NET Command-line Tools 2.1.3-rtm-32065
