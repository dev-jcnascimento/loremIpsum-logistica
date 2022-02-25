## Sobre o Projeto
Trata-se de uma API e Client para Cadastro de Clientes e Endereçõs desenvolvida em:<br>

**Back-end:**<br>
.NET 6<br>
*Entity Framework Core*,<br>
*SQL Server*<br>
*Seeding*<br>

**Front-end:**<br>
Angular<br>

## COMO RODAR O PROJETO
### BANCO DE DADOS
Foi usado o banco de dados SQL Server. Antes de rodar o projeto, é necessário executar o comando:

Primeiro, altere a string de conexão com o banco de dados localizada em .\

### INICIAR O PROJETO
Segundo, deve ser feito o build do projeto. 
<br>
Abra o cmd (prompt de comando) e digite:
>dotnet build

Agora, execute o update do banco de dados:
>dotnet ef database update --project ./
>
Depois, execute o comando para rodar o projeto:
>dotnet run --project ./

## DOCUMENTAÇÃO
Para ter acesso aos endpoints criados, acesse no navegador:
>
Para ter acesso aos endpoints criados utilizando o Postman, utilize o link para importar:
>
