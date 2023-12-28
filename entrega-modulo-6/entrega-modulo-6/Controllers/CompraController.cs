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
        public async Task<ActionResult<List<CompraModel>>> ListarCompras()
        {
            List<CompraModel> compra = await _compraRepository.BuscarTodasCompras();
            return Ok(compra);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompraModel>> BuscarPorId(int id)
        {
            CompraModel compra = await _compraRepository.BuscarPorId(id);
            return Ok(compra);
        }

        [HttpPost]
        public async Task<ActionResult<CompraModel>> Cadastrar([FromBody] CompraModel  compraModel)
        {
            CompraModel compra = await _compraRepository.Adicionar(compraModel);

            return Ok(compra);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CompraModel>> Atualizar([FromBody] CompraModel compraModel, int id)
        {
            
            CompraModel compra = await _compraRepository.Atualizar(compraModel, id);

            return Ok(compra);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CompraModel>> Deletar(int id)
        {

            bool deletado = await _compraRepository.Deletar(id);

            return Ok(deletado);
        }
    }
}
    

