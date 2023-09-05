using API_AppPousada_ControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppPousada_ControleEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Itens
    {
        private readonly PousadaTesteContext _dbContext;

        public Itens(PousadaTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<TblIten>> GruposIdCat()
        {
            try
            {
                var itens = await _dbContext.TblItens
                                    .Where(x => (x.Ativo ?? false) && (x.IdCategoria == 1 || x.IdCategoria == 2 || x.IdCategoria == 7))
                                    .OrderBy(p => p.Descricao)
                                    .ToListAsync(); // Obtenha os dados do banco de dados

                itens = itens
                    .Where(x => !x.Descricao.Contains("VENCIDA", StringComparison.OrdinalIgnoreCase) &&
                                !x.Descricao.Contains("VENC", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("VENCIDO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("DOSE", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PRIMOÇÃO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PROMOÇÃO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PROMOCÃO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PROMOCAO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PRIMO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("SHOT", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PORÇÃO", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("NATURAL", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("CAIPIRINHA", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("CAIPI", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("CAIPIROSKA", StringComparison.OrdinalIgnoreCase) && 
                                !x.Descricao.Contains("PROMO", StringComparison.OrdinalIgnoreCase))
                    .ToList(); // Filtragem em memória

                if (itens != null)
                {
                    return itens;
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpGet]
        [Route("itens-id")]
        public async Task<List<TblIten>> ItensId(int id)
        {
            try
            {
                var lista = await _dbContext.TblItens.Where(x => x.IdItem == id).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
