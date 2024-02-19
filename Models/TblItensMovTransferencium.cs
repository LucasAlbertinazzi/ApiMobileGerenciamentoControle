using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// histórico de transferências de um estoque para outro
/// </summary>
public partial class TblItensMovTransferencium
{
    public long IdItensTransf { get; set; }

    public string Sku { get; set; } = null!;

    public string Origem { get; set; } = null!;

    public string Destino { get; set; } = null!;

    public int Qtd { get; set; }

    public string Obs { get; set; } = null!;

    public string TransferidoPor { get; set; } = null!;

    public DateTime TransferidoEm { get; set; }
}
