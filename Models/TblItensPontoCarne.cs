using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// pontos possíveis da carne
/// </summary>
public partial class TblItensPontoCarne
{
    public int IdPontoCarne { get; set; }

    public string Descricao { get; set; } = null!;
}
