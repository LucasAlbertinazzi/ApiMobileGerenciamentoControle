using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// local em que cada item está e seu estoque
/// </summary>
public partial class TblItensEstoque
{
    public long IdItemEstoque { get; set; }

    public string? Sku { get; set; }

    public string? IdLocal { get; set; }

    public int? Qtd { get; set; }
}
