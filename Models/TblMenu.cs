using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblMenu
{
    public int Codigo { get; set; }

    public int? Codusuario { get; set; }

    public int? Botao { get; set; }

    public string? Legenda { get; set; }

    public string? Formulario { get; set; }
}
