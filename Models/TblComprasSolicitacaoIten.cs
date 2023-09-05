using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblComprasSolicitacaoIten
{
    public long IdCompraSolicitacaoItem { get; set; }

    public long IdCompraSolicitacao { get; set; }

    public string? Sku { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal Quantidade { get; set; }

    public string Unidade { get; set; } = null!;

    public DateTime LancadoEm { get; set; }

    public bool Comprado { get; set; }
}
