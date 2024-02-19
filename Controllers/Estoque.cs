using API_GerenciamentoGerenciamentoControle_Controle.Models;
using API_GerenciamentoGerenciamentoControle_Controle.Suporte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_GerenciamentoGerenciamentoControle_Controle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Estoque : ControllerBase
    {
        private readonly GerenciamentoControleTesteContext _dbContext;

        public Estoque(GerenciamentoControleTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("lista-contagens")]
        public async Task<List<TblContaEstoque>> Contagem()
        {
            try
            {
                var lista = await _dbContext.TblContaEstoques.Where(x => string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir)).OrderBy(x => x.DataAbre).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-contagem-fast")]
        public async Task<List<TblContaEstoque>> ContagemFast(string status)
        {
            try
            {
                var lista = await _dbContext.TblContaEstoques.Where(x => x.Finalizado == status && x.IdLista != null && x.Excluir == null).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-contagem-aberta")]
        public async Task<List<TblContaEstoque>> ConategmAberta()
        {
            try
            {
                var lista = await _dbContext.TblContaEstoques
                           .Where(x => x.Finalizado == null && x.Excluir == null)
                           .OrderBy(z => z.DataAbre)
                           .ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("lista-contagem-fechada")]
        public async Task<List<TblContaEstoque>> ConategmFechada(DataContagem dataContagem)
        {
            try
            {
                List<TblContaEstoque> lista = await _dbContext.TblContaEstoques
                            .Where(x => x.Finalizado == "S" && x.IdLista != null && x.Excluir == null
                                        && x.DataFecha <= dataContagem.inicio && x.DataFecha >= dataContagem.final)
                            .OrderBy(z => z.DataFecha)
                            .ToListAsync();

                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("lista-contagem-fast-id")]
        public async Task<List<TblContaEstoquePre>> ContagemFastId(int idCard)
        {
            try
            {
                var lista = await _dbContext.TblContaEstoquePres.Where(x => x.Idlista == idCard).ToListAsync();

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("historico-estoque-atual")]
        public async Task<List<EstoqueAtual>> HistoricoAtual(int idCard)
        {
            try
            {
                List<EstoqueAtual> atual = new List<EstoqueAtual>();

                var _pre = await _dbContext.TblContaEstoquePres.Where(x => x.Idlista == idCard).ToListAsync();

                foreach (var item in _pre)
                {
                    Decimal somar = 0;

                    var move = await _dbContext.TblItensMovs.Where(x => x.Sku == item.Sku && x.IdLocal == item.Idlocal).ToListAsync();

                    for (int i = 0; i < move.Count; i++)
                    {
                        if (move[i].Sku == item.Sku && move[i].IdLocal == item.Idlocal)
                        {
                            Decimal num = Convert.ToDecimal(move[i].Qtd);
                            somar = Decimal.Add(somar, num);
                        }
                    }

                    atual.Add(new EstoqueAtual
                    {
                        IdLista = item.Idlista,
                        Atual = somar
                    });
                }

                return atual;
            }

            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("id-ultima-lista")]
        public async Task<int?> UltimoId()
        {
            try
            {
                var lista = await _dbContext.TblContaEstoquePres.OrderByDescending(x => x.Idlista).FirstOrDefaultAsync();

                if (lista == null)
                {
                    return 0;
                }
                else
                {
                    return lista.Idlista;
                }
            }
            catch (Exception ex)
            {
                return 0000000;
            }
        }

        [HttpGet]
        [Route("lista-id-pre-iten")]
        public async Task<int> ListaIdPreItens(int iditem, int idlista)
        {
            try
            {
                var contaEstoquePres = await _dbContext.TblContaEstoquePres
                    .FirstOrDefaultAsync(x => x.Idlista == idlista && x.Iditem == iditem);

                if (contaEstoquePres != null)
                {
                    return contaEstoquePres.Id;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
        }


        [HttpPost]
        [Route("criar-contagem")]
        public async Task<ActionResult> Criar(TblContaEstoque tblConta)
        {
            try
            {
                _dbContext.TblContaEstoques.Add(tblConta);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("atualiza-contagem")]
        public async Task<ActionResult> AtualizaFull(TblContaEstoque tblConta)
        {
            try
            {
                var existingItem = await _dbContext.TblContaEstoques.FirstOrDefaultAsync(x => x.IdLista == tblConta.IdLista);

                if (existingItem != null)
                {
                    existingItem.IdCategoria = tblConta.IdCategoria;
                    existingItem.IdGrupo = tblConta.IdGrupo;
                    existingItem.DataFecha = tblConta.DataFecha;
                    existingItem.UserFecha = tblConta.UserFecha;
                    existingItem.IdLocal = tblConta.IdLocal;
                    existingItem.Finalizado = tblConta.Finalizado;
                    existingItem.Idcategorialista = tblConta.Idcategorialista;
                }

               await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("atualiza-pre-contagem-finaliza")]
        public async Task<ActionResult> AtualizaItensPreFinaliza(TblContaEstoquePre tblConta)
        {
            try
            {
                // Encontra todos os itens com o mesmo ID
                var itemsToUpdate = await _dbContext.TblContaEstoquePres
                    .Where(item => item.Idlista == tblConta.Idlista)
                    .ToListAsync();

                // Atualiza cada item encontrado
                foreach (var item in itemsToUpdate)
                {
                    item.Finaliza = "S";
                }

                // Salva as alterações no banco de dados
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna um BadRequest
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("criar-contagem-fast")]
        public async Task<ActionResult> CriarFast(List<TblContaEstoquePre> tblContaFast)
        {
            try
            {
                _dbContext.TblContaEstoquePres.AddRange(tblContaFast);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("att-itens-cont-pre")]
        public async Task<ActionResult> AtualizaItensContPre(TblContaEstoquePre tblContaFast)
        {
            try
            {
                var existingItem = await _dbContext.TblContaEstoquePres.FindAsync(tblContaFast.Id);

                if (existingItem != null)
                {
                    existingItem.Quantidade = tblContaFast.Quantidade;

                    _dbContext.Entry(existingItem).State = EntityState.Modified;
                }

                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpPost]
        [Route("adiciona-itens-cont-pre")]
        public async Task<ActionResult> AdicionaItensContPre(TblContaEstoquePre tblContaFast)
        {
            try
            {
                var existingItem = await _dbContext.TblContaEstoquePres.FindAsync(tblContaFast.Id);

                if (existingItem == null)
                {
                    _dbContext.TblContaEstoquePres.AddRange(tblContaFast);
                    await _dbContext.SaveChangesAsync();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpDelete]
        [Route("deletar-item-fast")]
        public async Task<ActionResult> DeletarFast(int idLista, string sku)
        {
            try
            {
                var linhaParaDeletar = await _dbContext.TblContaEstoquePres
                    .FirstOrDefaultAsync(x => x.Id == idLista && x.Sku == sku);

                if (linhaParaDeletar == null)
                    return NotFound(); // Se a linha não existir, retorna 404

                _dbContext.TblContaEstoquePres.Remove(linhaParaDeletar);
                await _dbContext.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("att-historico")]
        public async Task<ActionResult> AtualizaHistorico(List<EstoqueAtual> tbl)
        {
            try
            {
                var pre_estoque = _dbContext.TblContaEstoquePres.Where(x => x.Idlista == tbl[0].IdLista).ToList();

                if (pre_estoque != null)
                {
                    for (int i = 0; i < pre_estoque.Count; i++)
                    {
                        pre_estoque[i].Estoqueatual = tbl[i].Atual;
                        pre_estoque[i].Finaliza = "S";
                    }

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem atualizada com sucesso");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("att-contagem")]
        public async Task<ActionResult> AtualizaContagem(int id, string local, string user)
        {
            try
            {
                var estoque = _dbContext.TblContaEstoques.FirstOrDefault(x => x.IdLista == id && string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir));
                var pre_estoque = _dbContext.TblContaEstoquePres.Where(x => x.Idlista == id && string.IsNullOrEmpty(x.Finaliza));

                if (estoque != null && pre_estoque != null)
                {
                    estoque.Finalizado = "S";
                    estoque.DataFecha = DateTime.Now;
                    estoque.UserFecha = user;
                    estoque.IdLocal = local;

                    foreach (var item in pre_estoque)
                    {
                        item.Finaliza = "S";
                    }

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem atualizada com sucesso");
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("deleta-contagem")]
        public async Task<ActionResult> DeleteContagem(int id, string user)
        {
            try
            {
                var estoque = _dbContext.TblContaEstoques.FirstOrDefault(x => x.IdLista == id && string.IsNullOrEmpty(x.Finalizado) && string.IsNullOrEmpty(x.Excluir));

                if (estoque != null)
                {
                    estoque.Excluir = "S";
                    estoque.UserExcluir = user;

                    await _dbContext.SaveChangesAsync();
                    return Ok("Contagem deletada com sucesso");
                }

                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
