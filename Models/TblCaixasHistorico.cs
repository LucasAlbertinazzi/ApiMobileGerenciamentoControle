using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// aqui há um registro das operações que mudaram os valores dos caixas, como pagamentos e transferências.
/// a coluna id_documento puxa um valor que pode ser de distintas tabelas, como a tbl_pedido_compra.id_pedido_compra, se o tipo for &apos;Pagamento&apos; ou &apos;Estorno&apos;, ou tbl_caixas_vale.id_caixas_vale se o tipo for &apos;Vale-Crédito&apos; ou &apos;Vale-Débito&apos;, ou tbl_caixas_transferencia.id_caixas_transferencia se o tipo for &apos;Transferência-Origem&apos; ou &apos;Transferência-Destino&apos;
/// </summary>
public partial class TblCaixasHistorico
{
    public long IdCaixasHistorico { get; set; }

    public long IdFluxo { get; set; }

    public string Tipo { get; set; } = null!;

    public decimal Subtotal { get; set; }

    public decimal Acrescimo { get; set; }

    public decimal Desconto { get; set; }

    public decimal ValorTotal { get; set; }

    public int LancadoPor { get; set; }

    public DateTime LancadoEm { get; set; }

    public long IdDocumento { get; set; }
}
