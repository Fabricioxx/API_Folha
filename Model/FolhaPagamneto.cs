using System;

namespace Model
{
    public class FolhaPagamento
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime Data { get; set; }
        public decimal Salario { get; set; }
        public decimal Inss { get; set; }
        public decimal Ir { get; set; }
        public decimal SalarioLiquido { get; set; }

       

        


    }
}