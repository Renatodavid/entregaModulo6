using entrega_modulo6.Models;
using entrega_modulo6.Repositorys.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace entrega_modulo6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuario()
        {
            try
            {
                List<UsuarioModel> usuarios = await _usuarioRepository.BuscarTodosUsuario();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            try
            {
                UsuarioModel usuario = await _usuarioRepository.BuscarPorId(id);

                if (usuario == null)
                {
                    return NotFound("Usuário não encontrado");
                }

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            try
            {
                UsuarioModel usuario = await _usuarioRepository.Adicionar(usuarioModel);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        {
            try
            {
                usuarioModel.UsuarioId = id;
                UsuarioModel usuario = await _usuarioRepository.Atualizar(usuarioModel, id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Deletar(int id)
        {
            try
            {
                bool deletado = await _usuarioRepository.Deletar(id);
                return Ok(deletado);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }
    }
}
    
