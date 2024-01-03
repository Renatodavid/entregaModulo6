
using entrega_modulo6.Data;
using entrega_modulo6.Models;
using entrega_modulo6.Repositorys.Interface;
using Microsoft.EntityFrameworkCore;

namespace entrega_modulo6.Repositorys
{
    public class DestinoRepository : IDestinoRepository
    {


             private readonly entrega_modulo6DBContext _dbContext;

             public DestinoRepository(entrega_modulo6DBContext entrega_modulo6DBContext)
            {
                _dbContext = entrega_modulo6DBContext;
            }


        public async Task<DestinoModel> BuscarPorId(int id) => await _dbContext.Destino.FirstOrDefaultAsync(x => x.DestinoId == id);

        public async Task<List<DestinoModel>> BuscartodosDestinos()
        {
                return await _dbContext.Destino.ToListAsync();
            }

            public async Task<DestinoModel> Adicionar(DestinoModel destino)
            {
                

                 await _dbContext.Destino.AddAsync(destino);
                await _dbContext.SaveChangesAsync();

            
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Examine ex.InnerException e veja os detalhes específicos do erro do SQL Server
                Console.WriteLine($"Erro durante SaveChangesAsync: {ex.InnerException}");
            }

            return destino;
            }

        public async Task<DestinoModel> Atualizar(DestinoModel destino, int id)
            {
                DestinoModel destinoPorId = await BuscarPorId(id);

            if (destinoPorId == null)
                {
                    throw new Exception($" Destino de ID: {id} não foi encontrado no banco de dados!");
                }
                destinoPorId.NomeDestino = destino.NomeDestino;
                destinoPorId.Valor = destino.Valor;
                destinoPorId.DataChegada = destino.DataChegada;
                destinoPorId.DataSaida = destino.DataSaida;
                destinoPorId.HoraChegada = destino.HoraChegada;

                 _dbContext.Destino.Update(destinoPorId); 
                   await _dbContext.SaveChangesAsync();

                return destinoPorId;


            }

            public async Task<bool> Deletar(int id)
            {
                DestinoModel destinoPorId = await BuscarPorId(id);

            if (destinoPorId == null)
                {
                    throw new Exception($" Destino de ID: {id} não foi encontrado no banco de dados!");
                }

                _dbContext.Destino.Remove(destinoPorId);
                await _dbContext.SaveChangesAsync();
                return true;


            }        
    }
}

