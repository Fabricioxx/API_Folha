using System;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data{

    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext> options) : base(options){}
          
          //criando tabela funcionario
        public DbSet<Funcionario> Funcionarios { get; set; }

    }
   


}