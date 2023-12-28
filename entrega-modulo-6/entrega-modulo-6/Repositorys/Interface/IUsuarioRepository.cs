

using entrega_modulo6.Models;

namespace entrega_modulo6.Repositorys.Interface
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> BuscarTodosUsuario();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Deletar(int id);
    }
}
