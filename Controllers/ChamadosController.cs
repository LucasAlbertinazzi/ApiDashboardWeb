using ApiServicesWebChamados.Classes;
using Microsoft.AspNetCore.Mvc;

namespace ApiServicesWebChamados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadosController : ControllerBase
    {
        // Simula a fonte de dados com uma lista de objetos
        private static List<Chamado> _chamados = new List<Chamado>();

        [HttpGet]
        public ActionResult<IEnumerable<Chamado>> Get()
        {
            return _chamados;
        }

        [HttpGet("{id}")]
        public ActionResult<Chamado> GetById(int id)
        {
            var chamado = _chamados.FirstOrDefault(c => c.Id == id);

            if (chamado == null)
            {
                return NotFound();
            }

            return chamado;
        }

        [HttpGet("usuarios/{id}")]
        public IActionResult GetByUsuario(int id)
        {
            var chamadosUsuario = _chamados.Where(c => c.Codigo == id);
            return Ok(chamadosUsuario);
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Chamado chamado)
        {
            var chamadoExistente = _chamados.FirstOrDefault(c => c.Id == id);

            if (chamadoExistente == null)
            {
                return NotFound();
            }

            chamadoExistente.Titulo = chamado.Titulo;
            chamadoExistente.Descricao = chamado.Descricao;
            chamadoExistente.Status = chamado.Status;
            chamadoExistente.TempoDesenvolvimento = chamado.TempoDesenvolvimento;
            chamadoExistente.Setor = chamado.Setor;
            chamadoExistente.Tipo = chamado.Tipo;
            chamadoExistente.Numero = chamado.Numero;
            chamadoExistente.Prioridade = chamado.Prioridade;
            chamadoExistente.UsuarioAtual = chamado.UsuarioAtual;

            return Ok(chamadoExistente);
        }
    }
}
