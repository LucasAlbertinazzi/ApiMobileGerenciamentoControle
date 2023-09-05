using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblCaixasVale
{
    public long IdCaixasVale { get; set; }

    public long IdPedidoCompra { get; set; }

    public long IdFluxo { get; set; }

    public string MetodoVale { get; set; } = null!;

    public int LancadoPor { get; set; }

    public DateTime LancadoEm { get; set; }

    public string? Obs { get; set; }

    public string? Tipo { get; set; }
}
