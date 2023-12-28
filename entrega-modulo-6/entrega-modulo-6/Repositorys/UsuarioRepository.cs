
using entrega_modulo6.Data;
using entrega_modulo6.Models;
using entrega_modulo6.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;

namespace entrega_modulo6.Repositorys
{
    
    

        public class UsuarioRepository : IUsuarioRepository
        {

            private readonly entrega_modulo6DBContext _dbContext;

            public UsuarioRepository(entrega_modulo6DBContext entrega_moduloADBContext, entrega_modulo6DBContext entrega_modulo6DBContext)
            {
                _dbContext = entrega_modulo6DBContext;
            }


            public async Task<UsuarioModel> BuscarPorId(int id)
            {
                return await _dbContext.Usuario.FirstOrDefaultAsync(x => x.UsuarioId == id);
            }
            public async Task<List<UsuarioModel>> BuscarTodosUsuario()
            {
                return await _dbContext.Usuario.ToListAsync();
            }
            public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
            {
                await _dbContext.Usuario.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();

                return usuario;
            }

            public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
            {
                UsuarioModel usuarioPorId = await BuscarPorId(id);

                if (usuarioPorId == null)
                {
                    throw new Exception($" Usuário de ID: {id} não foi encontrado no banco de dados!");
                }
                usuarioPorId.Nome = usuario.Nome;
                usuarioPorId.Cpf = usuario.Cpf;

                _dbContext.Usuario.Update(usuarioPorId);
                await _dbContext.SaveChangesAsync();

                return usuarioPorId;


            }

            public async Task<bool> Deletar(int id)
            {
                UsuarioModel usuarioPorId = await BuscarPorId(id);

                if (usuarioPorId == null)
                {
                    throw new Exception($" Usuário de ID: {id} não foi encontrado no banco de dados!");
                }

                _dbContext.Usuario.Remove(usuarioPorId);
                await _dbContext.SaveChangesAsync();
                return true;


            }

        Task<List<UsuarioModel>> IUsuarioRepository.BuscarTodosUsuario()
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepository.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }
    }
    }


