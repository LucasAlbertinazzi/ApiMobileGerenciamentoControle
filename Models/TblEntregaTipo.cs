using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblEntregaTipo
{
    public int IdEntregaTipo { get; set; }

    public string? Tipo { get; set; }

    public string? Descricao { get; set; }

    public string? Responsabilidade { get; set; }

    public string? DescricaoResumida { get; set; }
}
