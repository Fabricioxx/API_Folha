using System;
using System.ComponentModel.DataAnnotations; //  
using Validations;


namespace Model
{
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int? Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres")]
        public string? Cpf { get; set; }

        [Range(0, 1000, ErrorMessage = "O salário deve estar entre R$ 0.00 e R$ 1.000,00")] 
        public double? Salario { get; set; }

        //
        [EmailAddress(ErrorMessage = "O e-mail é inválido")] 
        public string? Email { get; set; }

        public string? Celular { get; set; }

        [Required(ErrorMessage = "O cargo é obrigatório")]
        public string? Cargo { get; set; }
        public DateTime? Nascimento { get; set; }
        public DateTime? CriadoEm { get; set; }

        
        
        
           
        
        
    }
}