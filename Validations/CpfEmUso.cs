using System;
using System.Linq;
using Model;
using Data;
using System.ComponentModel.DataAnnotations; // para usar o [Validation] 

//
namespace Validations
{          // classe que valida se o cpf já está em uso
    public class CpfEmUso : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DataContext? context = (DataContext?)validationContext.GetService(typeof(DataContext)); // pega o contexto do banco de dados

            var cpf = (string?)value; // pega o valor do cpf

            Funcionario? Funcionario = context.Funcionarios.FirstOrDefault(f => f.Cpf == cpf); // procura no banco de dados se o cpf já existe

            if (Funcionario != null)
            {
                return new ValidationResult("CPF já está em uso");
            }
            return ValidationResult.Success; // se não houver erro, retorna sucesso
        }
    }
}