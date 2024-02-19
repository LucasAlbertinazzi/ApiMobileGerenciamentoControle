using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// histórico de preços dos ingredientes
/// </summary>
public partial class TblItensIngredientesHistPreco
{
    public long IdIngredienteHistPreco { get; set; }

    public int? IdIngrediente { get; set; }

    public decimal? Custo { get; set; }

    public DateTime? Data { get; set; }

    public int? LancadoPor { get; set; }

    public string? Unidade { get; set; }

    public decimal? Qtd { get; set; }
}
