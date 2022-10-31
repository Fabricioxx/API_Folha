using System;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data{

    public class DataContext : DbContext {




        
        //Entity Framework Code First
        //É a classe que define a estrutura do banco de dados
        public DataContext(DbContextOptions<DataContext> options) : base(options){ 

             

        }

          //Definir quais as classes de modelo servirão para as         
        //tabelas no banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FolhaPagamento> FolhaPagamentos { get; set; }




             

            

        //Sobrescrever o método OnModelCreating
        //para definir as chaves primárias e estrangeiras



    }
   


}