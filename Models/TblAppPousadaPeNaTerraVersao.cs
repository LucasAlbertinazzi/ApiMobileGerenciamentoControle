using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblAppPousadaPeNaTerraVersao
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Versao { get; set; }
}
