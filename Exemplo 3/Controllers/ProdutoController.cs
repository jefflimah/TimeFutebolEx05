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
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de Produtos");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Detalhes do Produto X");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            if (produto.precoVenda < 0)
            {
                return BadRequest("Preço Negativo, Tente Novamente!");
            }
            if (produto.estoque < 0)
            {
                return BadRequest("Estoque Negativo, Tente Novamente!");
            }
            if (produto.precoCusto < 0)
            {
                return BadRequest("Preço de Custo Negativo, Tente Novamente!");
            }
            if (string.IsNullOrEmpty(produto.nome))
            {
                return BadRequest("Nome em Branco, Tente Novamente!");
            }
            if (string.IsNullOrEmpty(produto.descricao))
            {
                return BadRequest("Descrição em Branco, Tente Novamente!");
            }
            return Ok("Produto Cadastrado com Sucesso!");
        }
    }
}
