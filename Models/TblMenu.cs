using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblMenu
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public int? Botao { get; set; }

    public string? Legenda { get; set; }

    public string? Formulario { get; set; }
}
