using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// Classificação dos itens,
/// 1-Categoria
/// 2-Grupo
/// 3-Subgrupo
/// </summary>
public partial class TblItens1Categorium
{
    public int IdCategoria { get; set; }

    public string? Descricao { get; set; }

    public string? CategoriaTransacao { get; set; }

    public int? IdUsuario { get; set; }

    public TimeOnly DataCriacao { get; set; }

    public virtual ICollection<TblIten> TblItens { get; set; } = new List<TblIten>();

    public virtual ICollection<TblItens2Grupo> TblItens2Grupos { get; set; } = new List<TblItens2Grupo>();
}
