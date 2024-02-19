using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblContrato
{
    public int Id { get; set; }

    public string NContrato { get; set; } = null!;

    public string? Contrato { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFinal { get; set; }

    public DateTime? Datavisualizou { get; set; }

    public int Ultimoacesso { get; set; }

    public bool Resolvido { get; set; }

    public DateTime? DtResolvido { get; set; }

    public int Usuarioresolveu { get; set; }

    public int IdFuncao { get; set; }

    public bool EnvioF4 { get; set; }
}
