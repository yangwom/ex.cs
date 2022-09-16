# Configuração de certificado HTTPS
Antes de executarmos essa API criada, precisamos dizer ao nosso computador que o certificado de desenvolvimento do .NET é confiável.

Para isso, execute o comando:

```bh
dotnet dev-certs https --trust
```