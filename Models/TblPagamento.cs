using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblPagamento
{
    public long IdPagamento { get; set; }

    public long IdPedidoCompra { get; set; }

    public DateTime Vencimento { get; set; }

    public int Parcela { get; set; }

    public int QtdParcelas { get; set; }

    public decimal ValorParcela { get; set; }

    public decimal Desconto { get; set; }

    public decimal Acrescimo { get; set; }

    public decimal ValorTotal { get; set; }

    public bool Pago { get; set; }

    public int? PagoPor { get; set; }

    public long? IdFluxo { get; set; }

    public decimal ValorPago { get; set; }

    public DateTime? DataPagamento { get; set; }

    public string? TipoPagamento { get; set; }

    public string? ObsPagamento { get; set; }

    public DateTime? LancadoEm { get; set; }

    public int? LancadoPor { get; set; }

    public bool Estornado { get; set; }

    public int? EstornadoPor { get; set; }

    public DateTime? EstornadoEm { get; set; }

    public string? EstornoObs { get; set; }

    public bool Liquidado { get; set; }

    public string? ChavePixPaga { get; set; }

    public bool Cancelado { get; set; }

    public string? ChaveBoletoPaga { get; set; }
}
