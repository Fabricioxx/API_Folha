# API_Folha
projeto web API da disciplina de desenvolvimento Microsoft

> [ Comandos Terminal VSCode ](https://clover-tailor-90b.notion.site/CLI-C-ed19b7637e21473282fa6c0e400ff925)

     - dotnet --version 
      - 6.0.400


### Passo a Passo

>  [Lista de Pacotes para baixar, para facilitar na Cração do Projeto](https://www.notion.so/Configura-o-de-Ambiente-8479c4cafd8f4fea9911e1c3c6fc30e6)


> Criar um Projeto no vscode Terminal

    - dotnet new webapi --name NomeDoProjeto 
    - dotnet new web -o nomeProjeto -f net5.0 (para escolher a versão )
  
> Criar as Pastas Model e Controllers e suas classes

 * Pasta Model
 
    - Funcionario.cs
    - FolhaPagamneto.cs
    
 * Pasta Controllers
 
    - FuncionarioController.cs
    
  * Pasta Data
  
    - DataContext.cs
    
 > Baixar os pacotes do Microsoft.EntityFrameworkCore
 
    - dotnet add package Microsoft.EntityFrameworkCore.SqLite
    - dotnet add package Microsoft.EntityFrameworkCore.Design
 
 > Criar o metodo na classe program.cs para o arquivo DataContext.cs e banco de dados sqlite

    - builder.Services.AddDbContext<DataContext>(options => options.UseSqlite("DataSource=database.db"));
    
    
 
 
    
   
  
  
