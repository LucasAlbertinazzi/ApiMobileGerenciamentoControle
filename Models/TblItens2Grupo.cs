using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// Classificação dos itens,
/// 1-Categoria
/// 2-Grupo
/// 3-Subgrupo
/// </summary>
public partial class TblItens2Grupo
{
    public int IdGrupo { get; set; }

    public string? Descricao { get; set; }

    public int IdCategoria { get; set; }

    public DateTime CadastradoEm { get; set; }

    public int CadastradoPor { get; set; }

    public virtual TblUsuario CadastradoPorNavigation { get; set; } = null!;

    public virtual TblItens1Categorium IdCategoriaNavigation { get; set; } = null!;
}
