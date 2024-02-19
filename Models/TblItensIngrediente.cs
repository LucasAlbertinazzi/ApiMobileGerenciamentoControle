using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// ingredientes utilizados nos alimentos
/// </summary>
public partial class TblItensIngrediente
{
    public int IdIngrediente { get; set; }

    public string? Descricao { get; set; }

    public string? Unidade { get; set; }

    public decimal? Custo { get; set; }

    public DateTime CadastradoEm { get; set; }

    public int? CadastradoPor { get; set; }

    public DateTime? AtualizadoEm { get; set; }

    public int? AtualizadoPor { get; set; }

    public string? Observacao { get; set; }

    public bool? Ativo { get; set; }

    public virtual ICollection<TblItensIngredientesMov> TblItensIngredientesMovs { get; set; } = new List<TblItensIngredientesMov>();
}
