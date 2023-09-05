using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblSessoesUsuario
{
    public long IdSessao { get; set; }

    public int IdUsuario { get; set; }

    public DateTime Data { get; set; }

    public virtual TblUsuario IdUsuarioNavigation { get; set; } = null!;
}
