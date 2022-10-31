using System;
using System.ComponentModel.DataAnnotations; //[key] [Required] [StringLength(50)] [Display(Name = "Nome")] public string Nome { get; set; } [Display(Name = "Salario")] public double Salario { get; set; } [Display(Name = "Desconto")] public double Desconto { get; set; } [Display(Name = "Total")] public double Total { get; set; } [Display(Name = "Data")] public DateTime Data { get; set; } }

namespace Model
{
    public class FolhaPagamento
    {

        public FolhaPagamento() => CriadoEm = DateTime.Now; // Construtor 

        [Key]
        public int? Id { get; set; }

        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double? SalarioBruto { get; set; } 
        public double? Inss { get; set; } 
        public double? Ir { get; set; } 
        public double? Fgts { get; set; } 
        public double? SalarioLiquido { get; set; } 

        public DateTime? CriadoEm { get; set; }

        public int Mes { get; set; } // Mês da folha de pagamento
        public int Ano { get; set; } // Ano da folha de pagamento


        // Relacionamento com a classe Funcionario
        public int? FuncionarioId { get; set; } 
        public Funcionario? funcionario { get; set; } 

       
        


    }
}