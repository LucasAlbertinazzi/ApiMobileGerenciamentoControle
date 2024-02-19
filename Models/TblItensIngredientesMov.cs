using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// movimentação de estoque dos ingredientes utilizados na cozinha, esta tabela está correlacionada com a tbl_itens_mov, uma vez que um sku teve movimentação, todos os seus ingredientes também devem ter movimentação.
/// </summary>
public partial class TblItensIngredientesMov
{
    public long IdIngredientesMov { get; set; }

    public int IdIngrediente { get; set; }

    public long IdItensMov { get; set; }

    public string Sku { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Unidade { get; set; } = null!;

    public decimal Qtd { get; set; }

    public bool? Ativo { get; set; }

    public virtual TblItensIngrediente IdIngredienteNavigation { get; set; } = null!;

    public virtual TblItensMov IdItensMovNavigation { get; set; } = null!;
}
