
using entrega_modulo6.Data;
using entrega_modulo6.Models;
using entrega_modulo6.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;

namespace entrega_modulo6.Repositorys
{
    public class CompraRepository : ICompraRepository
    {
        private readonly entrega_modulo6DBContext _dbContext;

       
        public CompraRepository(entrega_modulo6DBContext entrega_modulo6DBContext )
        {
            _dbContext = entrega_modulo6DBContext;
        }


        public async Task<CompraModel> BuscarPorId(int id)
        {
            return await _dbContext.Compra.FirstOrDefaultAsync(x => x.CompraId == id);
        }
        public async Task<List<CompraModel>> BuscarTodasCompras()
        {
            return await _dbContext.Compra.ToListAsync();
        }
        public async Task<CompraModel> Adicionar(CompraModel compra )
        {
            await _dbContext.Compra.AddAsync(compra);
            await _dbContext.SaveChangesAsync();

            return compra;
        }

        public async Task<CompraModel> Atualizar(CompraModel compra, int id)
        {
            CompraModel compraPorId = await BuscarPorId(id);

            if (compraPorId == null)
            {
                throw new Exception($" Usuário de ID: {id} não foi encontrado no banco de dados!");
            }
            compraPorId.CompraId = compra.CompraId;
            compra.Valor = compra.Valor;
            compra.Descricao = compra.Descricao;
           

            _dbContext.Compra.Update(compraPorId);
            await _dbContext.SaveChangesAsync();

            return compraPorId;


        }

        public async Task<bool> Deletar(int id)
        {
            CompraModel compraPorId = await BuscarPorId(id);

            if (compraPorId == null)
            {
                throw new Exception($" Usuário de ID: {id} não foi encontrado no banco de dados!");
            }

            _dbContext.Compra.Remove(compraPorId);
            await _dbContext.SaveChangesAsync();
            return true;


        }


    }
}

