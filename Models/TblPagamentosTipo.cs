using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblPagamentosTipo
{
    public long IdPagamentoTipo { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? LiquidadoNoPag { get; set; }

    public bool TransfForma { get; set; }
}
