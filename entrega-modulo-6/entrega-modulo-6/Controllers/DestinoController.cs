using entrega_modulo6.Models;
using entrega_modulo6.Repositorys.Interface;

using Microsoft.AspNetCore.Mvc;


namespace entrega_modulo6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private readonly IDestinoRepository _destinoRepository;

        public DestinoController(IDestinoRepository destinoRepository)
        {
            _destinoRepository = destinoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<DestinoModel>>> BuscarDestinos()
        {
            try
            {
                List<DestinoModel> destinos = await _destinoRepository.BuscartodosDestinos();
                return Ok(destinos);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DestinoModel>> BuscarPorId(int id)
        {
            try
            {
                DestinoModel destino = await _destinoRepository.BuscarPorId(id);

                if (destino == null)
                {
                    return NotFound("Destino não foi encontrado");
                }

                return Ok(destino);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<DestinoModel>> Cadastrar([FromBody] DestinoModel destinoModel)
        {
            try
            {
                DestinoModel destino = await _destinoRepository.Adicionar(destinoModel);
                return Ok(destino);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<DestinoModel>> Atualizar([FromBody] DestinoModel destinoModel, int id)
        {
            try
            {
                destinoModel.DestinoId = id;
                DestinoModel destino = await _destinoRepository.Atualizar(destinoModel, id);
                return Ok(destino);
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
                bool deletado = await _destinoRepository.Deletar(id);
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


    

