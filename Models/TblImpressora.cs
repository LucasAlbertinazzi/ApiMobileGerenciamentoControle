using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// dados impressoras de rede
/// </summary>
public partial class TblImpressora
{
    public int IdImpressora { get; set; }

    public string? Descricao { get; set; }

    public string? Ip { get; set; }

    public string? IdLocal { get; set; }

    public string? NomeSpooler { get; set; }

    public string? ModeloImpressora { get; set; }
}
