using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblComprasSolicitacaoItensCotacao
{
    public long IdCompraSolicitacaoItemCotacao { get; set; }

    public long IdCompraSolicitacaoItem { get; set; }

    public string CnpjFornecedor { get; set; } = null!;

    public DateTime CotadoEm { get; set; }

    public string Contato { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public decimal Preco { get; set; }

    public string? Unidade { get; set; }
}
