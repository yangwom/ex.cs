# Usos Comuns do ASP.NET

Com ASP.NET podemos desenvolver:

- Aplicações Web: é possível criar aplicações web com arquitetura MVC, a qual veremos com mais profundidade posteriormente;

- APIs REST: o ASP.NET Web API facilita a construção de APIs baseadas em protocolo HTTP com REST;

- Aplicações em tempo real: o SignalR é uma biblioteca do ASP.NET que permite a comunicação bidirecional entre o servidor e o cliente. Por meio dele, podemos gerenciar conexões e desconexões, enviar conteúdos por push e até mesmo comunicar jogos em tempo real;

- Microsserviços: com o ASP.NET também é possível a criação de microsserviços, estilo de arquitetura na qual um serviço é dividido em pequenos serviços na web.

O ASP.NET Core é um framework gratuito e open source da Microsoft, criado para ser o sucessor do ASP.NET.

Com o ASP.NET era necessário um ambiente Windows para que pudéssemos desenvolver e rodar uma aplicação. Com isso, o ASP.NET Core veio aumentar essa compatibilidade.

Ele foi lançado em 2016, sob o nome de “ASP.NET 5”, porém foi renomeado posteriormente por não ser somente mais uma versão do ASP.NET, mas sim uma remodelagem completa, tornando o framework multiplataforma.

Anota aí 🖊: Assim como o .NET Core, que é uma multiplataforma, o ASP.NET Core nos possibilita desenvolver e subir nossas aplicações não somente em Windows, mas também em Linux e MacOS.

# Iniciando pela linha de comando

Cria uma aplicação Web com arquitetura MVC:

- dotnet new mvc

Cria uma nova aplicação Web:

- dotnet new webapp

Cria uma API:

- dotnet new webapi

**No ASP.NET**, cada Model é uma classe que representa uma entidade do nosso banco e apresenta os dados em forma de propriedades públicas.

Vamos imaginar que devemos salvar um pessoa estudante no banco de dados da Trybe. Veja como esse exemplo fica em forma de código:

Copiar
using System;

namespace TrybeApp.Models
{
    public class TrybeStudent
    {
      public int Id { get; set; }
    	public string Name { get; set;  }
    	public int Age { get; set;  }
    	public int ClassNumber { get; set;  }
    }
}
Nesse exemplo, temos uma classe que representa a entidade de estudante com as seguintes informações: id, nome, idade e o número da turma.

Anota aí 🖊: A partir dessa classe, podemos mapear o que temos no nosso banco. Além disso, as outras partes da aplicação podem fazer uso dessa classe, ao invés de se conectarem diretamente com o banco de dados.

Anota aí 🖊: No ASP.NET MVC, por padrão, é utilizado o recurso de páginas Razor, uma sintaxe de criação de páginas web dinâmicas com HTML e C#, que possui a extensão .cshtml. As Views ficam armazenadas em uma pasta chamada Views, na raiz da aplicação, e cada uma leva o nome da sua Controller correspondente

# Camada de Controladores (Controller)

- A Controller é a porta de entrada das aplicações MVC, pois é responsável por receber as requisições que chegam no servidor. É nessa camada que acionamos a Model para interagir com o banco de dados ou chamamos funções da camada Service para validação das nossas regras de negócios.

No Contexto das Aplicações ASP.NET, cada Controller é uma classe derivada da classe Controller do próprio ASP.NET.

Essa classe-base contém métodos públicos chamados Action Methods.