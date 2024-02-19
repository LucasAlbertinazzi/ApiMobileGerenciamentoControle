using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// tabela com permissoes especiais de acesso do sistema
/// </summary>
public partial class TblPermisso
{
    public long IdPermissao { get; set; }

    public int? IdUsuario { get; set; }

    public string? Descricao { get; set; }

    public bool Permitido { get; set; }
}
