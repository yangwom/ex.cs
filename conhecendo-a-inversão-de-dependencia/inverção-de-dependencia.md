Princípio de Inversão de Dependências
O Princípio de Inversão de Dependências (DIP) do S.O.L.I.D. declara que:

Entidades de alto nível não devem depender de entidades de baixo nível. Ambos devem depender de abstrações.

Você pode estar se perguntando: “O que isso significa?” 🤔 Resposta: As classes não devem depender de outra classe concreta ou instanciável, mas sim de classes abstratas ou de interfaces. Isso faz com que o projeto fique mais robusto, pois ao alterar os detalhes de implementação ele não quebra.

Anota aí 🖊: A Inversão de Dependências também permite a reutilização das classes com implementações diferentes.

Para que você possa compreender melhor esse conceito, podemos fazer uma analogia pensando em um carro como um serviço, exercendo a função de transportar pessoas de um lugar a outro. O motor do carro pode precisar de gasolina, álcool ou eletricidade, mas esse detalhe não é importante para o cliente/motorista que se importa em chegar ao seu destino quando opta em utilizar um carro.

Os carros apresentam uma interface uniforme dos pedais, volante e outros controles. O tipo de motor que foi instalado na fábrica não importa para o cliente, pois este pode trocar de carro assim que achar necessário.

Com o desenvolvimento de softwares, a ideia é a mesma. Como as aplicações mudam constantemente e com grande velocidade, desacoplar as classes uma das outras permite que todo o serviço se mantenha mais estável e reutilizável. Essa é uma boa prática extremamente importante, para que um projeto seja escalado mais facilmente.

Anota aí 🖊: Classes com baixo acoplamento e com as responsabilidades segregadas corretamente trazem importantes benefícios, tais como:

- Facilidade na manutenção e evolução do serviço;
Com as classes fracamente acopladas, alterações que forem feitas em uma classe não afetarão diretamente as outras.

- Separação de responsabilidades;
Classes desacopladas não sabem da implementação de outras. Suas responsabilidades ficam encapsuladas somente dentro dela.

- Simplificação do desenvolvimento de testes unitários.
Quando queremos testar uma classe, não precisamos saber dos detalhes de implementação do serviço. Podemos simular as condições externas que irão entrar no nosso cliente.


- Injeção por Interface
  - A injeção por interface ocorre quando uma classe recebe uma abstração da implementação, a qual ela irá utilizar por meio de uma interface. Desta forma, quem define a implementação da abstração a ser utilizada é quem está utilizando a classe principal.

No exemplo do Pedal, os dispositivos recebem por interface os comportamentos de “Acionar()” e “Desacionar()”, e cada dispositivo concreto define a implementação dos métodos definidos pela abstração IDispositivo: