using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblFinanceiroDivTerc
{
    public int IdDivPrinc { get; set; }

    public int IdDivSecun { get; set; }

    public int IdDivTerc { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdCategoria { get; set; }

    public int IdGrupo { get; set; }
}
