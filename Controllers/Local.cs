using API_GerenciamentoGerenciamentoControle_Controle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_GerenciamentoGerenciamentoControle_Controle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Local
    {
        private readonly GerenciamentoControleTesteContext _dbContext;
        public Local(GerenciamentoControleTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<TblItensLocal>> Local_id(string id_local)
        {
            try
            {
                string nome_local = string.Empty;
                var _local = await _dbContext.TblItensLocals.Where(x => x.IdLocal == id_local).ToListAsync();

                return _local;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-local")]
        public async Task<List<TblItensLocal>> ListaLocal()
        {
            try
            {
                var _local = await _dbContext.TblItensLocals.ToListAsync();

                return _local;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
