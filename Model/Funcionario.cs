using System;

namespace Model
{
    public class Funcionario
    {
        //public Funcionario () => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }


         public Funcionario (int id, string nome, string cpf, DateTime nascimento){
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Nascimento = nascimento;
            CriadoEm = DateTime.Now;
         }


        
        
    }
}