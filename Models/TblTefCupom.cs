using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblTefCupom
{
    public int CupomFiscal { get; set; }

    public string Idtransacao { get; set; } = null!;

    public DateTime DataInicio { get; set; }

    public DateTime? DataTransacao { get; set; }

    public int Codusuario { get; set; }

    public long? NsuSitef { get; set; }

    public long? NsuHost { get; set; }

    public decimal Valor { get; set; }

    public string Pdv { get; set; } = null!;

    public int Parcelas { get; set; }

    public int TipoOperacao { get; set; }

    public string? Retornos { get; set; }

    public int? CupomCancelamento { get; set; }

    public string TipoRecebimento { get; set; } = null!;

    public string DocumentoRecebimento { get; set; } = null!;
}
