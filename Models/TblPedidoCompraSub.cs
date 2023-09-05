using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// detalhes adicionais do pedido de compra, com dados das despesas, investimentos, emprestimos 
/// </summary>
public partial class TblPedidoCompraSub
{
    public int IdPedidoCompraSub { get; set; }

    public int? IdPedidoCompra { get; set; }

    public string? Descricao { get; set; }

    public decimal? Qtd { get; set; }

    public decimal? ValorUnit { get; set; }

    public decimal? ValorTotal { get; set; }

    public bool? ComNota { get; set; }

    public DateTime? LancadoEm { get; set; }

    public int? LancadoPor { get; set; }

    public string? Sku { get; set; }

    public string? Ean { get; set; }

    public string? Ncm { get; set; }
}
