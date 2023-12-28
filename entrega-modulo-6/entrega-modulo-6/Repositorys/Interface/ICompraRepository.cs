

using entrega_modulo6.Models;

namespace entrega_modulo6.Repositorys.Interface
{
    public interface ICompraRepository
    {
        Task<List<CompraModel>> BuscarTodasCompras();
        Task<CompraModel> BuscarPorId(int id);
        Task<CompraModel> Adicionar(CompraModel compra);
        Task<CompraModel> Atualizar(CompraModel compra, int id);
        Task<bool> Deletar(int id);
    }
}
