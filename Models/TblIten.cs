using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// itens de consumo, tanto produtos quanto serviços
/// </summary>
public partial class TblIten
{
    public int IdItem { get; set; }

    public int SkuCb { get; set; }

    public string CodItemCb { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdSubgrupo { get; set; }

    public string? Sku { get; set; }

    /// <summary>
    /// volume em ML
    /// </summary>
    public decimal Volume { get; set; }

    /// <summary>
    /// peso em gramas
    /// </summary>
    public decimal Peso { get; set; }

    public bool? Ativo { get; set; }

    public DateTime CadastradoEm { get; set; }

    public int CadastradoPor { get; set; }

    public DateTime AtualizadoEm { get; set; }

    public int AtualizadoPor { get; set; }

    public int? IdReceita { get; set; }

    public string? Codbarra { get; set; }

    public bool InclusoReserva { get; set; }

    public decimal PrecoReserva { get; set; }

    public int LimiteReserva { get; set; }

    /// <summary>
    /// descrição reduzida para uso na cozinha
    /// </summary>
    public string? DescricaoCozinha { get; set; }

    public bool RefeicaoCompleta { get; set; }

    public bool ComplementoRefeicao { get; set; }

    public bool Cozinha { get; set; }

    public bool BarPiscina { get; set; }

    public bool Drink { get; set; }

    public string? Ean { get; set; }

    public string Unidade { get; set; } = null!;

    public long? IdFt { get; set; }

    public virtual TblUsuario AtualizadoPorNavigation { get; set; } = null!;

    public virtual TblUsuario CadastradoPorNavigation { get; set; } = null!;

    public virtual TblItens1Categorium? IdCategoriaNavigation { get; set; }

    public virtual ICollection<TblNfEntradaItem> TblNfEntradaItems { get; set; } = new List<TblNfEntradaItem>();
}
