using entrega_modulo6.Repositorys.Interface;
using entrega_modulo6.Models;



using Microsoft.AspNetCore.Mvc;

namespace Entrega_modulo6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : ControllerBase
    {

        private readonly ICompraRepository _compraRepository;

        public CompraController(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }


        [HttpGet]
        public async Task<ActionResult<List<CompraModel>>> BuscarTodasCompras()
        {
            try
            {
                List<CompraModel> compra = await _compraRepository.BuscarTodasCompras();
                return Ok(compra);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompraModel>> BuscarPorId(int id)
        {
            try
            {


                CompraModel compra = await _compraRepository.BuscarPorId(id);
                if(compra == null)
                {
                    return NotFound("Compra não encontrada");
                }
                    return Ok(compra);

            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<CompraModel>> Cadastrar([FromBody] CompraModel  compraModel)
        {
            try
            {
                CompraModel compra = await _compraRepository.Adicionar(compraModel);

                return Ok(compra);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }


        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CompraModel>> Atualizar([FromBody] CompraModel compraModel, int id)
        {

            try
            {
                compraModel.CompraId = id;
                CompraModel compra = await _compraRepository.Atualizar(compraModel, id);

                return Ok(compra);
            }
            catch (Exception ex)
            {
                // Lidar com exceções, registrar, etc.
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CompraModel>> Deletar(int id)
        {

            try
            {
                bool deletado = await _compraRepository.Deletar(id);

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
    

