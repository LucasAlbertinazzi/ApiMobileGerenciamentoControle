using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblFinanceiroDivSecun
{
    public int IdDivSecun { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdDivPrinc { get; set; }

    public virtual TblFinanceiroDivPrinc IdDivPrincNavigation { get; set; } = null!;
}
