using System;

namespace Model
{
    public class FolhaPagamento
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime Data { get; set; }
        public double Salario { get; set; }
        public double Inss { get; set; }
        public double Ir { get; set; }
        public double SalarioLiquido { get; set; }

       

        


    }
}