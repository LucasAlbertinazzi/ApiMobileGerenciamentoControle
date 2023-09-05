using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblPermissoesAcessosUsuario
{
    public long IdAcessoUsuario { get; set; }

    public int IdUsuario { get; set; }

    public int IdAcesso { get; set; }

    public bool Permitido { get; set; }

    public int LancadoPor { get; set; }

    public DateTime LancadoEm { get; set; }

    public int? AtualizadoPor { get; set; }

    public DateTime? AtualizadoEm { get; set; }
}
