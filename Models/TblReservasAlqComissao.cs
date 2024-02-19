using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblReservasAlqComissao
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public decimal Comissao { get; set; }
}
