using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// tipos de status de reserva
/// </summary>
public partial class TblReservasStatus
{
    public int IdStatus { get; set; }

    public string? Descricao { get; set; }

    public string? DescricaoCb { get; set; }

    public bool? Hospedagem { get; set; }
}
