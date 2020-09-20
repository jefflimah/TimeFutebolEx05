using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de Categoria");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Detalhes da Categoria");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria)
        {
            if (string.IsNullOrEmpty(categoria.titulo)){
                return BadRequest("Título está vazio, Tente Novamente!");
            }

            return Ok("Categoria Criada com Sucesso!");
        }


    }
}
