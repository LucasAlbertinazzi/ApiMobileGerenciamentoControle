using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblCaixasTransferencium
{
    public long IdCaixasTransferencia { get; set; }

    public long IdFluxoOrigem { get; set; }

    public long? IdFluxoDestino { get; set; }

    public long IdCaixaDestino { get; set; }

    public string Forma { get; set; } = null!;

    public decimal Valor { get; set; }

    public DateTime Data { get; set; }

    public int TransferidoPor { get; set; }

    public bool Recebido { get; set; }

    public DateTime? RecebidoEm { get; set; }

    public int? RecebidoPor { get; set; }
}
