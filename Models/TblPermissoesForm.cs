using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// permissão por usuário com o nome da form
/// </summary>
public partial class TblPermissoesForm
{
    public long IdPermissaoForm { get; set; }

    public string Form { get; set; } = null!;

    public int IdUsuario { get; set; }

    public DateTime ConcedidaEm { get; set; }

    public int ConcedidaPor { get; set; }

    public int Nivel { get; set; }
}
