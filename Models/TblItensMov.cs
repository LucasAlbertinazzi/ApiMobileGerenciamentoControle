using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// entradas e saídas de um determinado item
/// coluna qtd: 
/// entrou é positivo
/// saiu é negativo
/// 
/// </summary>
public partial class TblItensMov
{
    public long IdItensMov { get; set; }

    public string Sku { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public decimal Qtd { get; set; }

    public DateTime Data { get; set; }

    public string IdLocal { get; set; } = null!;

    public string? Obs { get; set; }

    public bool? Ativo { get; set; }

    public string Unidade { get; set; } = null!;

    public virtual ICollection<TblItensIngredientesMov> TblItensIngredientesMovs { get; set; } = new List<TblItensIngredientesMov>();
}
