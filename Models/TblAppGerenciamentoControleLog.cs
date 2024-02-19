using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblAppGerenciamentoControleLog
{
    public int Id { get; set; }

    public string? Metodo { get; set; }

    public string? Erro { get; set; }

    public string? TelaClasse { get; set; }

    public string? Dispositivo { get; set; }

    public DateTime? Data { get; set; }

    public string? Plataforma { get; set; }

    public string? Versao { get; set; }
}
