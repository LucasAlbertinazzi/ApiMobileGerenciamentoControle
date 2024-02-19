using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// dados de cada comanda, barcode
/// </summary>
public partial class TblConsumoComandaBarcode
{
    public int IdComanda { get; set; }

    public string? Barcode { get; set; }

    public bool? Utilizada { get; set; }

    public bool Funcionario { get; set; }

    public int? IdUsuario { get; set; }
}
