# Operações de leitura

```c#
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController
{
    [HttpGet]
    public string Get() => "Hello world!";
}

```

- Agora vamos analisar os pontos principais da definição desse controller:

```c#
  using Microsoft.AspNetCore.Mvc;
```

- Mesmo que não estejamos construindo um projeto com a arquitetura MVC, os atributos ApiController, Route() e HttpGet, que são utilizados para fazer com que nossa classe funcione como um controller, são parte do namespace Microsoft.AspNetCore.Mvc, então precisamos utilizá-lo aqui.

```c#
  [ApiController]
```

- O atributo ApiController tem como função indicar para o compilador que uma classe tem como função servir respostas às requisições HTTP feitas para a API.

Com isso, a utilização desse atributo permite que a aplicação identifique, de forma inteligente, se as informações enviadas para a api vêm do body, do header ou de queries na própria url. Veremos os efeitos disso de forma detalhada nos próximos tópicos.

```c#
  [Route("[controller]")]
```

O atributo `Route() ` tem como função indicar qual a rota pela qual o controller em questão é acessado. Se utilizássemos uma rota Route("ServiceOne"), por exemplo, poderíamos fazer requisições utilizando a url https://<endereço>/ServiceOne.

Nesse caso, é utilizado também o token replacement [controller]. O atributo Route() permite utilizar essa funcionalidade para definir automaticamente os valores entre colchetes ([, ]) com base no nome da classe que define o controller, ou seja, o controller que definimos poderá ser acessado pela rota https://<endereço>/HelloWorld.

Se o nome da nossa classe fosse RandomController, a url seria https://<endereço>/HelloWorld, e assim por diante.

```c#
  public class HelloWorldController
  {
  }

```

É a classe que utilizamos para definir o controller. Por convenção, sempre definimos essa classe com o padrão <NomeDoController>Controller, o que nos permite usar o Route() com o token replacement.
```c#
[HttpGet]
```
O atributo HttpGet é um dos atributos que definem os tipos de requisição aos quais os métodos poderão responder, baseado nos verbos HTTP. No caso, como estamos fazendo uma chamada de leitura simples, usamos o HttpGet, mas existem atributos para todos os tipos de verbo.

```c#
  public string Get() => "Hello world!";
```
- O método que irá ser executado quando fizermos uma chamada HTTP para a rota do controller. É possível definir mais de um método dentro do mesmo controller que responde ao mesmo tipo de requisição, mas para isso precisamos, além de usar o atributo Route() no controller, utilizá-lo novamente no método novo, o que criará uma sub-rota para esse método dentro do controller.

Assim, podemos por exemplo definir um novo método public string GetHelloTrybe() => "Hello Trybe!"; com os atributos [HttpGet] e Route("2"), o que fará com que tenhamos duas rotas:

Vale ressaltar ainda que esse método poderá retornar ou receber objetos complexos, que serão convertidos em json automaticamente. Poderemos ver isso melhor com um endpoint que responda a uma chamada de criação ao invés de leitura.

E teremos a seguinte resposta:

```json
  "hello Word"
```

## Requisições que alteram dados

A forma mais simples de um controller é a que foi apresentada anteriormente, para requisições do tipo GET. Mas, como você já sabe, existem ocasiões em que precisaremos alterar informações no lado do servidor, e não apenas consultá-las.

Operações de criação (POST)
Para operações de criação, podemos utilizar tanto o verbo POST quanto o verbo PUT, sendo mais comum utilizar o primeiro. Vamos criar um controller que crie novos objetos, então?

Primeiro, precisamos definir um tipo de objeto que queremos criar. Fazemos isso com uma classe simples que será parte do nosso domínio/core. Se quisermos um objeto que represente um cliente de uma instituição financeira, por exemplo, podemos representá-lo da seguinte forma:

```c#
namespace TestApi.Core;

public class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

```
A partir de agora, poderemos utilizar essa classe para modelar o tipo de informação que queremos guardar no servidor. Todavia, antes de fazer isso, precisamos criar um objeto específico apenas com as informações que receberemos na requisição, afinal não será o cliente quem determinará o id ou a data de criação do objeto, e sim o servidor:

```c#
public class ClientRequest
{
    public string? Name { get; set; }
    public decimal AccountBalance { get; set; }

    public Client CreateClient(int id)
    {
        return new Client
        {
            Id = id,
            Name = Name,
            AccountBalance = AccountBalance,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }
}
```

Através dessa objeto, poderemos receber na requisição um objeto que possua apenas as informações de nome e balanço da conta e que seja capaz de criar um objeto do tipo Client com as informações faltantes. Agora já podemos criar nosso controller com um método POST:

```c#
[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {
        var client = request.CreateClient(_nextId++);
        _clients.Add(client);

        return StatusCode(201, client);
    }
}
```
Avaliando esse novo controller, temos aqui algumas informações extras. Primeiramente, estamos herdando da classe ControllerBase. Essa classe é parte do pacote Microsoft.AspNetCore.Mvc e contém, dentre outras utilidades, os métodos que utilizaremos para retornar as respostas HTTP corretas.

Além do mais, temos aqui dois campos estáticos:

- _clients: serve para guardar os clientes que enviarmos através do controller;
- _nextId: serve para controlar a atribuição de Ids únicos na nossa aplicação, evitando Ids repetidos mesmo que alguma entrada seja deletada.

Aviso ⚠️: Aqui, ao invés de utilizar um banco de dados, como faríamos na vida real, estamos utilizando campos estáticos para salvar as informações. Isso é feito apenas para exemplificar o funcionamento básico do método POST, mas não faremos isso em aplicações reais, pois essas informações serão apagadas assim que que encerrarmos a aplicação. Você aprenderá a utilizar o ASP.NET com bancos de dados em uma lição posterior.

O método em si possui o atributo HttpPost, que define que esse é o tipo de requisições que será recebido, e retorna como resposta o tipo ActionResult. Esse tipo representa o resultado de uma requisição feita pelo browser que será retornada pelo servidor.

O ASP.NET suporta diversos tipos de respostas derivadas de ActionResult, dentre os quais:

 - ViewResult 
   - Representa uma resposta em HTML.
EmptyResult - Representa uma resposta vazia.

- JsonResult 
  - Representa uma resposta em formato JSON.

- ContentResult 
  - Representa uma resposta em formato de texto simples.
Todos esses tipos são retornados dinamicamente pelos métodos do ControllerBase, podendo figurar como resposta nos controllers que utilizarem o ActionResult como tipo de retorno.

O método StatusCode(), que usamos no nosso controller, retorna um objeto do tipo ObjectResult, que também é um subtipo de ActionResult. Esse objeto, ao ser devolvido ao browser, indicará uma resposta do tipo “Created” (201), que terá como corpo o objeto criado.

## Operações de atualização (PUT)

Para trabalhar com operações de atualização, iremos utilizar o verbo HTTP PUT. Embora o verbo PUT, semanticamente, sirva também para criar elementos, ele funciona de maneira diferente do POST, pois, em regra, o Id do objeto criado será passado pela pessoa usuária, e não gerando pelo sistema.

Se liga na dica ✏️: por conta da polivalência do PUT, é possível utilizar requisições desse tipo para fazer operações de upsert, que é quando enviamos um objeto e, caso ele exista, fazemos um update; caso não exista, o criamos sob o Id em questão.

Outro detalhe é que também é possível fazer atualizações corretas semanticamente utilizando o verbo HTTP PATCH. Todavia, o uso dessa palavra é menos comum no contexto do ASP.NET por conta de requisições de PUT receberem o objeto completo e o PATCH poder receber apenas os campos a serem atualizados. Como no C# trabalhamos de forma orientada a objetos, é bem mais simples utilizar um objeto de request que deve ser totalmente preenchido do que tentar pegar os campos do corpo da requsição dinamicamente.

Outra vantagem de usar o PUT e atualizar objetos passando todos os dados novamente é que as requisições feitas com o PUT são idempotentes, ou seja, várias requisições idênticas terão sempre o mesmo resultado, pois todos os campos são garantidamente os mesmos, o que não ocorre com o PATCH.

No nosso caso, utilizaremos o PUT para a atualização dos objetos que foram criados anteriormente usando o POST. Para isso, vamos criar o seguinte método na classe ClientController, que criará um novo endpoint:

```c#
[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {...}

    [HttpPut("{id}")]
    public ActionResult Update(int id, ClientRequest request)
    {
        var client = _clients.FirstOrDefault(c => c.Id == id);

        if (client == null)
            return NotFound("Client not found");

        request.UpdateClient(client);

        return Ok(client);
    }
}
```

# Operações de remoção (DELETE)

O verbo HTTP DELETE é autoexplicativo e serve para quando, ao invés de criar ou atualizar um registro presente no servidor, queremos, por algum motivo, removê-lo daquele contexto.

delete
Embora normalmente, em situações reais, não seja recomendado deletar registros de uma base de dados, para que se possa manter um histórico auditável do funcionamento da aplicação, o ato de deletar registros pode ser necessário. Um exemplo disso é quando um cliente exige que seus dados pessoais sejam apagados, pois a LGPD obriga as empresas a não manter em seus sistemas dados pessoais de clientes sem a devida autorização.

Para criar um método DELETE no ASP.NET, poderemos fazer o seguinte:

```c#
[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {...}

    [HttpPut("{id}")]
    public ActionResult Update(int id, ClientRequest request)
    {...}

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var removed = _clients.RemoveAll(c => c.Id == id);

        if (removed == 0)
            return NotFound("Client not found");

        return NoContent();
    }
}
```
Assim como no PUT, utilizamos aqui o id como parâmetro na url, sendo nesse caso desnecessário passar um corpo na requisição.

Como em operações de deleção também não é necessário retornar nenhum tipo de conteúdo (embora isso possa ser feito com uma mensagem de sucesso, por exemplo), podemos utilizar o método NoContent(), que retorna um “No Content” (204), comumente utilizado em operações desse tipo.