using API_AppPousada_ControleEstoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_AppPousada_ControleEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categoria : ControllerBase
    {
        private readonly PousadaTesteContext _dbContext;

        public Categoria(PousadaTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        //POST api/<lista-categoria-pelo-id>
        [HttpPost]
        public async Task<string> Categoria_id(int id)
        {
            try
            {
                string nome_cat = string.Empty;
                var _categoria = await _dbContext.TblItens1Categoria.Where(x => x.IdCategoria == id).ToListAsync();

                foreach (var item in _categoria)
                {
                    nome_cat = item.Descricao;
                }

                return nome_cat;
            }
            catch (Exception ex)
            {
                return "Erro ao realizar a consulta";
            }
        }

        //GET api/<lista-todas-as-categorias>
        [HttpGet]
        [Route("lista-categorias")]
        public async Task<List<TblItens1Categorium>> ListaLocal()
        {
            try
            {
                var _categorias = await _dbContext.TblItens1Categoria.ToListAsync();

                return _categorias;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
