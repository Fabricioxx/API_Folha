using System;
using Microsoft.AspNetCore.Mvc;
using Model;
using Data;


namespace Controllers
{
    [ApiController]
    [Route("api/folha")]
    public class FolhaPagamentoController : ControllerBase
    {
        

         private readonly DataContext _context;
         public FolhaPagamentoController(DataContext context)
         {
             _context = context;
         }
         

         [HttpPost]
         [Route("calcular/{idFuncionario}")]
         public IActionResult Calcular([FromBody] FolhaPagamento folha, [FromRoute] int idFuncionario)
         {
             Funcionario? funcionario = _context.Funcionarios.FirstOrDefault(f => f.Id == idFuncionario); //busca o funcionário no banco de dados
             if(funcionario == null)
             {
                 return NotFound("Funcionario não encontrado");
             }
             else
             {

                 folha.FuncionarioId = funcionario.Id;
                 folha.funcionario = funcionario; //atribui o funcionário encontrado ao funcionário da folha

                 folha.SalarioBruto = funcionario.Salario; //atribui o salário do funcionário encontrado ao salário da folha

                 folha.Inss = folha.SalarioBruto * 0.075d; //7.5% do salario
                 folha.Ir = folha.SalarioBruto * 0.05d; //5%
                 folha.SalarioLiquido = folha.SalarioBruto - folha.Inss - folha.Ir; //salario - inss - ir

                 folha.Fgts = folha.SalarioBruto * 0.08d; //8% do salario

                 folha.Ano = DateTime.Now.Year; //ano atual
                 folha.Mes = DateTime.Now.Month; //mês atual

                 _context.FolhaPagamentos.Add(folha); //adiciona a folha no contexto
                 _context.SaveChanges(); //salva as alterações no banco de dados

                 return Created("", folha); //retorna um Created com a folha calculada
             }
         }
        


            [HttpGet]
            [Route("Buscar/{id}")]
            public IActionResult Buscar([FromRoute] int id)
            {
                FolhaPagamento? folha = _context.FolhaPagamentos.FirstOrDefault(f => f.Id == id); //busca a folha no banco de dados
                if(folha == null)
                {
                    return NotFound("Folha não encontrada");
                }
                else
                {
                    int? idfun = folha.FuncionarioId;

                  Funcionario? funcionario = _context.Funcionarios.FirstOrDefault(f => f.Id == idfun); //busca o funcionário no banco de dados

                    folha.funcionario = funcionario; //atribui o funcionário encontrado ao funcionário da folha

                    return Ok(folha); //retorna um Ok com a folha encontrada
                }
            }



            [HttpGet]
            [Route("listar")]
            public IActionResult Listar(){

                
             var Lista = _context.FolhaPagamentos.ToList(); //retorna uma lista de folhas do banco de dados

                for(int i = 0; i < Lista.Count; i++){

                Lista[i].funcionario = _context.Funcionarios.FirstOrDefault(x => x.Id == Lista[i].FuncionarioId); //busca o funcionário no banco de dados e atribui ao funcionário da folha

                 }

                return Ok(Lista); //retorna um Ok com a lista de folhas
            }

                     


            [HttpGet]
            [Route("listar/{idFuncionario}")]
            public IActionResult Listar([FromRoute] int idFuncionario)
            {
                List<FolhaPagamento> folhas = _context.FolhaPagamentos.Where(f => f.FuncionarioId == idFuncionario).ToList(); //busca a folha no banco de dados pelo id do funcionario
                if(folhas == null)
                {
                    return NotFound("Folha não encontrada");
                }
                else
                {

                    for(int i = 0; i < folhas.Count; i++){

                    folhas[i].funcionario = _context.Funcionarios.FirstOrDefault(x => x.Id == folhas[i].FuncionarioId); //busca o funcionário no banco de dados e atribui ao funcionário da folha

                    }
                    


                    return Ok(folhas); //retorna um Ok com a folha encontrada
                }
            }



            [HttpDelete]
            [Route("excluir/{id}")]
            public IActionResult Excluir([FromRoute] int id)
            {
                FolhaPagamento? folha = _context.FolhaPagamentos.FirstOrDefault(f => f.Id == id); //busca a folha no banco de dados
                if(folha == null)
                {
                    return NotFound("Folha não encontrada");
                }
                else
                {
                    _context.FolhaPagamentos.Remove(folha); //remove a folha do banco de dados
                    _context.SaveChanges(); //salva as alterações

                    return Ok("Folha excluída com sucesso"); //retorna um Ok com a mensagem de sucesso
                }
            }

          


        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] FolhaPagamento folha)
        {
            _context.FolhaPagamentos.Update(folha); //atualiza a folha no banco de dados
            _context.SaveChanges(); //salva as alterações

            return Ok("Folha alterada com sucesso"); //retorna um Ok com a mensagem de sucesso
        }
        






    }
}