using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblHistoricoPedidosEcommerce
{
    public int Id { get; set; }

    public string Codpedido { get; set; } = null!;

    public int? Coddepartamento { get; set; }

    public string? Obs { get; set; }

    public DateTime? Data { get; set; }
}
