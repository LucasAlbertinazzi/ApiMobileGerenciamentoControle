using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblCaixasFluxo
{
    public long IdFluxo { get; set; }

    public long IdCaixa { get; set; }

    public decimal CaixaInicial { get; set; }

    public decimal CaixaFinal { get; set; }

    public decimal Entradas { get; set; }

    public decimal Saidas { get; set; }

    public bool Aberto { get; set; }

    public DateTime Data { get; set; }

    public int UtilizadoPor { get; set; }

    public DateTime? FechadoEm { get; set; }

    public int? FechadoPor { get; set; }
}
