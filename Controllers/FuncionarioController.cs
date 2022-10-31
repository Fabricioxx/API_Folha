using System;
using Microsoft.AspNetCore.Mvc;
using Model;
using Data;
namespace Controllers
{
    
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {
            //readonly impede que a variável seja alterada por outra classe
           private readonly DataContext _context;


              //Construtor da classe FuncionarioController que recebe um DataContext
              public FuncionarioController(DataContext context)//
              {
                _context = context;
              }


        //READ ALL - GET http://localhost:5001/api/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok(_context.Funcionarios.ToList()); // retorna um Ok com a lista de funcionários

        //POST CREATE
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Funcionario funcionario){


            _context.Funcionarios.Add(funcionario); //adiciona o funcionário no contexto
            _context.SaveChanges(); //salva as alterações no banco de dados

            return Created("", funcionario); //retorna um Created com o funcionário cadastrado
        }

        
        //READ BY ID OU CPF
         [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf){
                                                                 // FirstOrDefault retorna o primeiro elemento da lista que satisfaz a condição
            Funcionario? funcionario = _context.Funcionarios.FirstOrDefault(f => f.Cpf == cpf); //busca o funcionário no banco de dados pelo cpf

            if(funcionario == null){

                return NotFound("FUNCIONARIO NÃO ENCONTRADO"); //retorna um NotFound caso o funcionário não seja encontrado

            }
            else
            {

                return Ok(funcionario); //retorna um Ok com o funcionário encontrado / o swegger irá mostrar o funcionário encontrado em formato JSON
                
            }
                
        }


        //DELETE
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id){ 

           Funcionario? funcionario = _context.Funcionarios.Find(id); //busca o funcionário no banco de dados pelo id

            if(funcionario == null){

                return NotFound("FUNCIONARIO NÃO ENCONTRADO"); //retorna um NotFound caso o funcionário não seja encontrado
            }
            else
            {
                _context.Funcionarios.Remove(funcionario); //remove o funcionário do contexto
                _context.SaveChanges(); //salva as alterações no banco de dados
                return Ok("FUNCIONARIO DELETADO"); //retorna um Ok com a mensagem de funcionário deletado 
            }
        }



        //UPDATE
        [HttpPatch]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar([FromRoute] int id, [FromBody] Funcionario funcionario){
 
           
            if(funcionario == null || funcionario.Id != id){

                return BadRequest("FUNCIONARIO NÃO ENCONTRADO"); //retorna um BadRequest caso o funcionário não seja encontrado
            }
            else
            {
                _context.Funcionarios.Update(funcionario); //atualiza o funcionário no contexto
                _context.SaveChanges(); //salva as alterações no banco de dados
                return Ok("FUNCIONARIO ATUALIZADO"); //retorna um Ok com a mensagem de funcionário atualizado
            }
           
        }


    }



  
}