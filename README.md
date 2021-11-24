<h1> WebApi ToDoList </h1>

<p>Projeto desenvolvido em C# ultilizando Asp.Net Core 5.0</p>
<h3>Dependências</h3>
<ul>
  <li>Entity Framework Core 5.0</li>
  <li>Entity Framework Core Tools 5.0<</li>
  <li>Entity Framework Core SQLServer 5.0</li>
  <li>AutoMapper.Extensions.Microsoft.DependencyInjection 8.1.1</li>
</ul>

<h3>Solução</h3>
<p>A solução foi desenvolvida aplicando o conceito de Solid, desta forma foi separado a WebApi e suas bibliotecas de classes.</p>

<h3>Banco de Dados</h3>
<p>O banco de dados utilizado, foi o SQLServer 13.0.4</p>
<p>Existe uma cópia para o banco na pasta DataBase, da qual é necessária sua importação, para execução da aplicação.</p>
<p>Para a configuração do SQLServer, caso não utilize o SQLServer Local do Visual Studio, é necessário alterar as configurações do arquivo appsettings.json e da classe Startup.</p>
<p>Caso não queira importar o DataBase, existe o arquivos Migrations, para uma nova migração do banco.</p>

<h3>Build</h3>
<p>Para o Build é necessário instalar as dependências e adicionar as bibliotecas.</p>
<p>Também é necessário importar o Banco de Dados ou realizar uma migração nova.</p>
<p>Para teste de rotas e verificação das mesma utilize o swagger no navegador, na seguinte rota: "/swagger/index.html"</p>



