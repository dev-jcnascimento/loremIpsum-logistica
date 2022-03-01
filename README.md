## Sobre o Projeto
Trata-se de uma API e Client para Cadastro de Clientes e Endereçõs desenvolvida em:<br>

**Back-end:**<br>
.NET 6<br>
*Entity Framework Core*,<br>
*SQL Server*<br>
*Versionamento de EndPoints*<br>
*Testes Unitários*<br>

<p><img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/006.PNG" width="350" height="300" alt="API Social Games" title="API Social Games">
<img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/007.PNG" width="350" height="300" alt="API Social Games" title="API Social Games"><p>

**Front-end:**<br>
Angular 13<br>
Angular Material<br>
  
<p><img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/001.PNG" width="320" height="200" alt="API Social Games" title="API Social Games">
<img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/002.PNG" width="320" height="200" alt="API Social Games" title="API Social Games">  
 <img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/003.PNG" width="320" height="200" alt="API Social Games" title="API Social Games">
    
<p><img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/004.PNG" width="320" height="200" alt="API Social Games" title="API Social Games">
<img src="https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/img/005.PNG" width="320" height="200" alt="API Social Games" title="API Social Games">

  
## COMO RODAR O PROJETO
### BANCO DE DADOS
Foi usado o banco de dados SQL Server. Antes de rodar o projeto, é necessário:<br>
Altere a string de conexão com o banco de dados localizada em .\LoremIpsumLogistica.Api\appsettings.json<br>

Depois, você pode escolher utilizar a função:<br>
>dotnet update-database --project ./LoremIpsumLogistica.Api

Que irá criar uma Database nova sem popular.<br>

Ou utilizar o script que se encontra em:<br>
>./script.sql ./LoremIpsumLogistica.Api

No Script possue Schemas e Datas.<br>

### INICIAR O PROJETO BACKEND
Agora execute o comando para rodar o projeto:
>dotnet run --project ./LoremIpsumLogistica.Api

### INICIAR O PROJETO BACKEND
Agora execute o comando para rodar o projeto:
>ng serve ./LoremIpsumLogistica.Client

## DOCUMENTAÇÃO
Para ter acesso aos endpoints criados, acesse no navegador:
>https://localhost:7155/swagger/index.html

Para ter acesso aos endpoints criados utilizando o Postman, acesse o link para importar a Collection File:
>https://github.com/dev-jcnascimento/loremIpsum-logistica/blob/master/postman_collection
