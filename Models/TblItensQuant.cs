using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// quantidades de estoque estático de um dado SKU.
/// Só utilizado em casos de itens físicos, não utilizado em serviços.
/// </summary>
public partial class TblItensQuant
{
    public string Sku { get; set; } = null!;

    public string IdLocal { get; set; } = null!;

    public int Qtd { get; set; }

    public DateTime UltimaMov { get; set; }
}
