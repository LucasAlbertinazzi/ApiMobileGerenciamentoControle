using API_GerenciamentoGerenciamentoControle_Controle.Models;
using API_GerenciamentoGerenciamentoControle_Controle.Suporte;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_GerenciamentoGerenciamentoControle_Controle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Grupo : ControllerBase
    {
        private readonly GerenciamentoControleTesteContext _dbContext;

        public Grupo(GerenciamentoControleTesteContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<List<GruposCategoria>> GpCat(string IdGrupo, int IdCategoria, string IdLocal)
        {
            List<GruposCategoria> gruposCategorias = new List<GruposCategoria>();
            string nomes_grupos = string.Empty;

            var _grupos = await _dbContext.TblItens2Grupos.ToListAsync();
            var _categoria = await _dbContext.TblItens1Categoria.Where(x => x.IdCategoria == IdCategoria).ToListAsync();
            var _local = await _dbContext.TblItensLocals.Where(x => x.IdLocal == IdLocal).ToListAsync();

            string[] _id = IdGrupo.ToString().Split(',');

            for (int i = 0; i < _id.Length; i++)
            {
                foreach (var item in _grupos)
                {
                    if (item.IdGrupo == Int32.Parse(_id[i]) && item.IdCategoria == IdCategoria)
                    {
                        nomes_grupos += item.Descricao + ",";
                    }
                }
            }

            nomes_grupos = nomes_grupos.TrimEnd(',');

            gruposCategorias.Add(new GruposCategoria
            {
                categoria = _categoria[0].Descricao,
                grupo = nomes_grupos,
                local = _local[0].Local
            });

            return gruposCategorias;
        }

        //GET api/<grupos-id-cat>
        [HttpGet]
        [Route("grupos-id-cat")]
        public async Task<List<TblItens2Grupo>> GruposIdCat(int id_cat)
        {
            var grupos = await _dbContext.TblItens2Grupos.Where(x =>
            x.IdCategoria == id_cat).ToListAsync();

            if (grupos == null)
            {
                return null;
            }

            else
            {
                return grupos;
            }
        }

        [HttpGet]
        [Route("lista-grupos")]
        public async Task<List<TblItens2Grupo>> Grupos()
        {
            var lista = await _dbContext.TblItens2Grupos.ToListAsync();

            return lista;
        }
    }
}
