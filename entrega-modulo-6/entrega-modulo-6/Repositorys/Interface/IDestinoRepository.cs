
using entrega_modulo6.Models;

namespace entrega_modulo6.Repositorys.Interface
{
    public interface IDestinoRepository
    {
        Task<List<DestinoModel>> BuscartodosDestinos();
        Task<DestinoModel> BuscarPorId(int id);
        Task<DestinoModel> Adicionar(DestinoModel destino);
        Task<DestinoModel> Atualizar(DestinoModel destino, int id);
        Task<bool> Deletar(int id);
    }
}
