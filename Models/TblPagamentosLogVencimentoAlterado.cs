using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblPagamentosLogVencimentoAlterado
{
    public long IdPagamentoLogVencAlterado { get; set; }

    public long IdPagamento { get; set; }

    public DateTime VencimentoOrigem { get; set; }

    public DateTime VencimentoDestino { get; set; }

    public int AlteradoPor { get; set; }

    public DateTime AlteradoEm { get; set; }
}
