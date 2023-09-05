using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// lista os tipos de movimento de estoque, utilizados na classe Itens.cs em sua movimentação, inclusão ou baixa
/// </summary>
public partial class TblItensMovTipo
{
    public int IdItensMovTipo { get; set; }

    public string Descricao { get; set; } = null!;

    public bool Manual { get; set; }
}
