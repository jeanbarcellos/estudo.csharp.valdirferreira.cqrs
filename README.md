_Repositório apenas para estudo_

# Video: Cadastro CQRS Simples utilizando o MEDIATOR ASP.NET Core c#

Nessa aula , demonstramos a utilização do "Mediator" como mediador entre nossas interfaces e nossa implementação.
Criamos um cadastro simples sem acesso ao banco utilizando um simples CQRS.

Foram Instalados nessa aula 2 pacotes para utilização do Mediator via nugget.
1 - MediatR
2 - MediatR.Extensions.Microsoft.DependencyInjection

Instrutor:

- [Valdir Ferreira](https://www.youtube.com/channel/UCQpk_XT9AUYjd2mUqW1wkpw)

Referências:

- [Vídeo - Cadastro CQRS Simples utilizando o MEDIATOR ASP.NET Core c#](https://www.youtube.com/watch?v=wvN-AhRFj0s)
- [Github - Código-fonte](https://github.com/ValdirFerreira/MEDIATOR-CQRS-SIMPLES)

<br>
<br>
<hr>

## Teórico

Você saque o que é design pattern mediator?

- É um padrão de projeto usado frequentemente quando deseja-se encapsular como os objetos interagem, ou seja, a comunicação entre os objetos é estabelecida através do Mediator.

- Este padrão é considerado um padrão comportamental, pois o padrão pode alterar o comportamento da aplicação (programa).

- O Mediator promove o fraco acoplamento ao evitar que objetos se referiram uns aos outros explicitamente.


## Prático

```bash
# Criar a api
dotnet new webapi -n WebMediator -o src/WebMediator

# Criar a solution
dotnet new sln -n Mediator

# Adicionar o projeto a solution
dotnet sln add src/WebMediator/

```