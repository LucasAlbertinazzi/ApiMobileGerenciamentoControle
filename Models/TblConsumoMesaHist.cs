using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblConsumoMesaHist
{
    public long IdHistMesa { get; set; }

    public int? IdMesa { get; set; }

    public DateTime? AbertaEm { get; set; }

    public int? AbertaPor { get; set; }

    public DateTime? FechadaEm { get; set; }

    public int? FechadaPor { get; set; }

    public string? Tipo { get; set; }

    public string? Documento { get; set; }

    public virtual TblUsuario? AbertaPorNavigation { get; set; }

    public virtual TblUsuario? FechadaPorNavigation { get; set; }
}
