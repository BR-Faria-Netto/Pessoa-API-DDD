using Dominio.Interfaces;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using Servico.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IBaseServico<Pessoa> _basePessoaServico;

        public PessoaController(IBaseServico<Pessoa> basePessoaServico)
        {
            _basePessoaServico = basePessoaServico;
        }

        
        [HttpPost("Incluir")]
        public IActionResult Adicionar([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
                return NotFound();

            return Execute(() => _basePessoaServico.Adicionar(pessoa).Id);

        }

        [HttpPost("Alterar")]
        public IActionResult Atualizar([FromBody] Pessoa pessoa)
        {
            if (pessoa == null)
                return NotFound();

            return Execute(() => _basePessoaServico.Atualizar(pessoa));
        }

        [HttpDelete("Excluir/{Id}")]
        public IActionResult Deletar(int id)
        {
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _basePessoaServico.Deletar(id);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            return Execute(() => _basePessoaServico.BuscarTodos());
        }

        [HttpGet("BuscarId/{id}")]
        public IActionResult BuscarPorId(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _basePessoaServico.BuscarPorId(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
