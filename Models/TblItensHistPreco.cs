using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// histórico de preço de um item
/// </summary>
public partial class TblItensHistPreco
{
    public long IdItemHistPreco { get; set; }

    public string Sku { get; set; } = null!;

    public decimal Preco { get; set; }

    public DateTime Data { get; set; }

    public int IdUsuario { get; set; }
}
