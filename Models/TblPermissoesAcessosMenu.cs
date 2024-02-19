using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// tela com os acessos da WpfPrincipal
/// </summary>
public partial class TblPermissoesAcessosMenu
{
    public int IdAcesso { get; set; }

    public string NomeAcesso { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
