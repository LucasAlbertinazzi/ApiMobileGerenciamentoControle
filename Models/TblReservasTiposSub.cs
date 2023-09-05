using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblReservasTiposSub
{
    public int IdReservaSubtipo { get; set; }

    public string Tipo { get; set; } = null!;

    public string Subtipo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public bool? Ativo { get; set; }
}
