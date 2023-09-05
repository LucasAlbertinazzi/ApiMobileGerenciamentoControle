using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblUsuariosFuncao
{
    public long IdFuncao { get; set; }

    public string Funcao { get; set; } = null!;

    public bool Admin { get; set; }

    public string? LocaisTrabalho { get; set; }
}
