using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblCaixasPermissao
{
    public int IdCaixasPermissao { get; set; }

    public int IdCaixa { get; set; }

    public int IdUsuario { get; set; }

    public DateTime ConcedidoEm { get; set; }

    public int ConcedidoPor { get; set; }
}
