using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// listagem comandas diário
/// </summary>
public partial class TblConsumoComandum
{
    public int IdComanda { get; set; }

    public string? NomeCliente { get; set; }

    public DateOnly Data { get; set; }

    public TimeOnly Hora { get; set; }

    public int? Mesa { get; set; }

    public string? Obs { get; set; }

    public int? GeradaPor { get; set; }

    public bool Fechada { get; set; }

    public DateTime? FechadaEm { get; set; }

    public int? FechadaPor { get; set; }
}
