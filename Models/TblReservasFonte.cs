using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblReservasFonte
{
    public int IdReservaFonte { get; set; }

    public string Fonte { get; set; } = null!;
}
