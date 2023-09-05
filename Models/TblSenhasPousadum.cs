using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblSenhasPousadum
{
    public int Id { get; set; }

    public string? Login { get; set; }

    public string? Senha { get; set; }

    public int? Tipo { get; set; }

    public string? Link { get; set; }

    public string? Descricao { get; set; }

    public string? Usercad { get; set; }

    public DateTime? Datacad { get; set; }

    public int? Funcao { get; set; }
}
