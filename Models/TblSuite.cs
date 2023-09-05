using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblSuite
{
    public long IdSuite { get; set; }

    public string Acomodacao { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public string Instalacoes { get; set; } = null!;
}
