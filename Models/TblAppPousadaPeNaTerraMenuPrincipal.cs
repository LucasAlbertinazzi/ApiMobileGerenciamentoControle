using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblAppPousadaPeNaTerraMenuPrincipal
{
    public int Id { get; set; }

    public string? TextoBtn { get; set; }

    public string? NomeMetodo { get; set; }

    public bool? BtnAtivo { get; set; }

    public string? DepPermitidos { get; set; }

    public DateTime? Data { get; set; }

    public string? CodIcone { get; set; }
}
