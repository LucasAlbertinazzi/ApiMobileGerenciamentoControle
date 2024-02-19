using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblAppGerenciamentoControleVersao
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Versao { get; set; }
}
