using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// ingredientes de uma ficha técnica
/// </summary>
public partial class TblItensFichaTecnicaIngrediente
{
    public long IdFt { get; set; }

    public string Sku { get; set; } = null!;

    public decimal QtdBruta { get; set; }

    public decimal QtdLiquida { get; set; }

    public decimal Aproveitamento { get; set; }

    public string Unidade { get; set; } = null!;

    public decimal CustoBruto { get; set; }

    public decimal CustoLiquido { get; set; }

    public int LancadoPor { get; set; }

    public DateTime LancadoEm { get; set; }
}
