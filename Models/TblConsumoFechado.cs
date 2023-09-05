using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// consumos que foram pagos.
/// </summary>
public partial class TblConsumoFechado
{
    public long IdConsumoFechado { get; set; }

    public string Tipo { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public decimal Subtotal { get; set; }

    public decimal Desconto { get; set; }

    public decimal TaxaServico { get; set; }

    public decimal Total { get; set; }

    public string? IdLocal { get; set; }

    public DateTime Data { get; set; }

    public int LancadoPor { get; set; }

    public string? Observacao { get; set; }

    public bool ErroFechamento { get; set; }
}
