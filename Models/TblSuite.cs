using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblSuite
{
    public long IdSuite { get; set; }

    public string Acomodacao { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Abreviatura { get; set; } = null!;

    public string Instalacoes { get; set; } = null!;
}
