using API_GerenciamentoGerenciamentoControle_Controle.Models;
using API_GerenciamentoGerenciamentoControle_Controle.Suporte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_GerenciamentoGerenciamentoControle_Controle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Itens : ControllerBase
    {
        private readonly GerenciamentoControleTesteContext _dbContext;

        public Itens(GerenciamentoControleTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<TblIten>> GruposIdCat()
        {
            try
            {
                //Foi removido a categoria 1 e 7 temporariamente
                //Categoria 1 = Alimentos
                //Categoria 2 = Bebidas
                //Categoria 7 = Ingredientes

                var itens = await _dbContext.TblItens
                                    .Where(x => (x.Ativo ?? false) && (x.IdCategoria == 1 || x.IdCategoria == 2 || x.IdCategoria == 7))
                                    .OrderBy(p => p.Descricao)
                                    .ToListAsync();

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

        [HttpGet]
        [Route("estoque-previsto")]
        public async Task<ActionResult<EstoquePrevisto>> EstoquePrevisto(string sku)
        {
            try
            {
                var estoquePrevisto = await (from cep in _dbContext.TblContaEstoquePres
                                             where cep.Sku == sku
                                             && cep.Finaliza == "S"
                                             group cep by cep.Sku into g
                                             select new
                                             {
                                                 Sku = g.Key,
                                                 estAntigo = g.Max(x => x.Quantidade),
                                                 ultCont = g.Max(x => x.Datasave)
                                             })
                                              .FirstOrDefaultAsync();

                var vendas = new { sku = "0", total_vendas = 0 };

                if (estoquePrevisto != null)
                {
                   vendas = await (from consumo in _dbContext.TblConsumos
                                        where consumo.Sku == sku && consumo.Data > estoquePrevisto.ultCont
                                        group consumo by consumo.Sku into g
                                        select new
                                        {
                                            sku = g.Key,
                                            total_vendas = g.Sum(x => x.Qtd)
                                        }).FirstOrDefaultAsync();
                }
                

                if (estoquePrevisto == null)
                {
                    return new EstoquePrevisto(); // Retorna 404 se não houver resultados encontrados
                }

                // Mapeia os resultados para a classe EstoquePrevisto
                var resultado = new EstoquePrevisto
                {
                    sku = estoquePrevisto.Sku,
                    estantigo = estoquePrevisto.estAntigo,
                    vendas = vendas != null ? vendas.total_vendas : 0,
                    estprev = estoquePrevisto.estAntigo - (vendas != null ? vendas.total_vendas : 0)
                };

                return Ok(resultado);
            }
            catch (Exception)
            {
                return StatusCode(500); // Ou outro código de erro apropriado
            }
        }
    }
}
