SQL Server com Docker
Antes de tudo, precisamos da imagem base que será utilizada, que será a imagem oficial do SQL Server.

Agora que sabemos a imagem que utilizaremos, podemos partir para a configuração do contêiner. Para isso, vamos criar um contêiner utilizando um volume de dados compartilhado entre o computador host e o contêiner. Isso serve para, caso você queira remover o contêiner ou trocar por qualquer motivo, você não perca os dados armazenados no banco de dados. Esse é um tipo de configuração bem comum quando se trata de contêineres para bancos de dados.

Para isso utilizamos a flag -v ao executar o contêiner e passamos para ela o valor pasta/no/pc/host:pasta/no/container. No caso do SQL Server, precisamos mapear a pasta /var/opt/mssql/data.

A imagem que utilizaremos como base também precisa da configuração de algumas variáveis de ambiente, que são:

ACCEPT_EULA: Para confirmar que a pessoa usuária do SQL Server aceitou os termos de serviço.
MSSQL_SA_PASSWORD: A senha que será usada para o perfil de pessoa usuária administradora.
MSSQL_USER: Nome de pessoa usuária usado no SQL Server. (opcional. A omissão dessa variável criará um usuário padrão apelidado do sa)
Agora podemos juntar todas essas informações e executar o comando:

Copiar
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=<SuaSenhaForte!>' -p 1433:1433 -v <diretório da máquina host>:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2019-latest
SQL Server com Docker
Antes de tudo, precisamos da imagem base que será utilizada, que será a imagem oficial do SQL Server.

Agora que sabemos a imagem que utilizaremos, podemos partir para a configuração do contêiner. Para isso, vamos criar um contêiner utilizando um volume de dados compartilhado entre o computador host e o contêiner. Isso serve para, caso você queira remover o contêiner ou trocar por qualquer motivo, você não perca os dados armazenados no banco de dados. Esse é um tipo de configuração bem comum quando se trata de contêineres para bancos de dados.

Para isso utilizamos a flag -v ao executar o contêiner e passamos para ela o valor pasta/no/pc/host:pasta/no/container. No caso do SQL Server, precisamos mapear a pasta /var/opt/mssql/data.

A imagem que utilizaremos como base também precisa da configuração de algumas variáveis de ambiente, que são:

ACCEPT_EULA: Para confirmar que a pessoa usuária do SQL Server aceitou os termos de serviço.
MSSQL_SA_PASSWORD: A senha que será usada para o perfil de pessoa usuária administradora.
MSSQL_USER: Nome de pessoa usuária usado no SQL Server. (opcional. A omissão dessa variável criará um usuário padrão apelidado do sa)
Agora podemos juntar todas essas informações e executar o comando:

```bdocdh
docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=<SuaSenhaForte!>' -p 1433:1433 -v <diretório da máquina host>:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2019-latest
```