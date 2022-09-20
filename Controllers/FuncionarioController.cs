using System;
using Microsoft.AspNetCore.Mvc;
using Model;
namespace Controllers
{
    
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {

        //READ ALL
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar() => Ok("Listar");

        //CREATE
         [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Funcionario funcionario){

            return Created("", funcionario);
        }

        
        //READ BY ID OU CPF
         [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf){
                
                return Ok("FUNCIONARIO BUSCADO");
        }


        //DELETE
        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar([FromRoute] int id){


            return Ok("FUNCIONARIO DELETADO");
        }



        //UPDATE
        [HttpPatch]
        [Route("atualizar/{id}")]
        public IActionResult Atualizar([FromRoute] int id, [FromBody] Funcionario funcionario){

            return Ok("FUNCIONARIO ATUALIZADO");
        }


    }



  
}