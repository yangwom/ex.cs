# Definindo arquitetura REST

O REST é um modelo de como desenvolver APIs dentro de determinados padrões, garantindo assim uma melhor comunicação entre os sistemas, inclusão de semântica e padronização para os verbos HTTP (GET, POST, PUT, DELETE, PATCH…), melhor escrita de endpoints e o uso padronizado dos status code HTTP, que são:

Respostas de informação (100-199)
Respostas de sucesso (200-299)
Redirecionamentos (300-399)
Erros do cliente (400-499)
Erros do servidor (500-599)
Agora, imagine, por exemplo, uma API onde temos os seguintes endpoints:

/user/GetUser/{id} do tipo GET
/user/adicionar do tipo POST
Ambas as rotas acima são exemplos de más práticas quando estamos falando de uma API REST:

Na primeira rota, o verbo GET já traz a ideia de buscar a informação, não sendo preciso repeti-la no endpoint com GetUser.

Na segunda rota, o POST já tem em sua semântica que irá criar/adicionar algo, não sendo preciso repetir a informação com a palavra adicionar.

Anota aí 🖊: REST padroniza como devemos escrever nossos endpoints. Seguir esses padrões é muito importante, porque endpoints bem escritos podem até mesmo reduzir a complexidade do nosso código. 😱

Características de uma API RESTful
Uma API é considerada RESTful quando segue à risca o padrão REST, isto é, quando aplica:

 - Interface uniforme
 - Arquitetura cliente-servidor
 - Sem Estado
 - Dados armazenáveis em cache
 - Sistema em camadas
 - Código sob demanda
A seguir, veremos cada ponto descrito acima de forma mais aprofundada.

# Arquitetura Cliente-Servidor

Acontece quando as comunicações são feitas via protocolo HTTP, seguindo uma arquitetura baseada em clientes, servidores e recursos.

Recurso é um substantivo que representa um objeto na vida real. No endpoint citado acima, /produtos/cosméticos, produtos é um exemplo de recurso.

# Sem estado

Cada comunicação entre cliente-servidor, para ser atendida, deve conter todos os dados necessários, não dependendo de informações armazenadas anteriormente em outras requisições.

Exemplificando, é como se estivéssemos em um fast-food, onde a pessoa cliente faz um pedido e, a partir dele, o restaurante o prepara e entrega normalmente, não sendo necessária nenhuma informação prévia antes de o pedido ser de fato feito pela pessoa cliente. 🍔🍟

# Dados Armazenáveis em Cache

Sabe quando você vai ao seu restaurante favorito e o garçom logo na entrada te pergunta: “ O de sempre?”. Essa analogia representa muito bem os dados armazenáveis em Cache.

As respostas das requisições precisam ser possíveis de serem armazenadas em memória de rápido acesso, para que sejam utilizadas em requisições futuras. Com os dados armazenáveis em cache, as solicitações e respostas entre cliente-servidor ficam otimizadas.

# Sistema em camadas

Cada camada do sistema possui sua funcionalidade específica, tanto no processo de requisição quanto na resposta à comunicação entre cliente e servidor.

Anota aí 🖊: Embora essas camadas sejam separadas, elas interagem entre si de forma hierárquica, com contratos de comunicação específicos ou eventos estabelecidos para o processamento das informações entre essas unidades.

# Código sob demanda

É a capacidade de uma API REST processar e responder a uma requisição quando ela chegar. Não se trata de velocidade, mas sim de disponibilidade, mesmo que a requisição cause erros.

Caso ocorram erros, uma API deve tratá-los e responder adequadamente à requisição, informando que ocorreram erros e instruindo quem fez a requisição a corrigi-los

# Comando **dotnet publish**
Depois de criarmos nossa API e aprendermos a deixá-la RESTful, vamos nos preparar para publicá-la.

Anota aí 🖊: O comando dotnet publish é responsável por compilar seu aplicativo, deixando-o apto para produção. Ele vai ler as dependências especificadas no arquivo do projeto e publicar em um diretório o conjunto desses arquivos, uma versão compilada de sua aplicação .NET. Essa versão resultante do comando dotnet publish estará pronta para implantação em um sistema de hospedagem, por exemplo, um servidor, um computador, um laptop, e será executada.

De olho na dica👀: Outro ponto importante é que, ao utilizar o comando dotnet publish -c Release -o out, você está criando uma versão preparada para produção da sua aplicação. Caso a sua configuração do Swagger seja apenas para o ambiente de desenvolvimento, ela não estará disponível nessa versão para produção.

E finalmente finalizamos nosso aquivo Dockerfile. Agora ele está pronto para executar aplicações .NET WebAPI. 🎉

