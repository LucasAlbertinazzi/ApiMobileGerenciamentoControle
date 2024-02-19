using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblItensFichaTecnica
{
    public long IdFt { get; set; }

    public string Sku { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public decimal? CustoReceita { get; set; }

    public decimal? CustoPorcao { get; set; }

    public decimal? RendimentoPorcoes { get; set; }

    public string? ModoPreparo { get; set; }

    public int CriadaPor { get; set; }

    public DateTime CriadaEm { get; set; }

    public bool? Ativo { get; set; }
}
