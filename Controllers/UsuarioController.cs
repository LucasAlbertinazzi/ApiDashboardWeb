using ApiServicesWebChamados.Classes;
using Microsoft.AspNetCore.Mvc;

namespace ApiServicesWebChamados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly List<Usuario> _usuarios;

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _usuarios;
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        [HttpPost]
        public ActionResult<Usuario> Post(Usuario usuario)
        {
            usuario.Id = _usuarios.Count + 1;
            _usuarios.Add(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }
    }
}
