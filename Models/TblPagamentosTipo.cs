using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblPagamentosTipo
{
    public long IdPagamentoTipo { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? LiquidadoNoPag { get; set; }

    public bool TransfForma { get; set; }
}
