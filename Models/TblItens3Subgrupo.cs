using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// Classificação dos itens,
/// 1-Categoria
/// 2-Grupo
/// 3-Subgrupo
/// </summary>
public partial class TblItens3Subgrupo
{
    public int IdCategoria { get; set; }

    public int IdGrupo { get; set; }

    public int IdSubgrupo { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime DataCriacao { get; set; }
}
