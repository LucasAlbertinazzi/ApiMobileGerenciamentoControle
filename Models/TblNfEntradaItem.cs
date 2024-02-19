using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblNfEntradaItem
{
    public int Id { get; set; }

    public int NfEntradaId { get; set; }

    public string CodigoProduto { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? Ean { get; set; }

    public int Ncm { get; set; }

    public int Cest { get; set; }

    public int Cfop { get; set; }

    public string UnidadeComercial { get; set; } = null!;

    public decimal QuantidadeComercial { get; set; }

    public decimal ValorUnitario { get; set; }

    public decimal ValorTotal { get; set; }

    public int? Item { get; set; }

    public decimal Frete { get; set; }

    public int IndTot { get; set; }

    public decimal TotalTributo { get; set; }

    public int IcmsOrig { get; set; }

    public int IcmsCst { get; set; }

    public int IcmsModbc { get; set; }

    public decimal IcmsVbc { get; set; }

    public decimal IcmsP { get; set; }

    public decimal IcmsV { get; set; }

    public int PisCst { get; set; }

    public decimal PisBc { get; set; }

    public decimal PisP { get; set; }

    public decimal PisV { get; set; }

    public int CofinsCst { get; set; }

    public decimal CofinsBc { get; set; }

    public decimal CofinsP { get; set; }

    public decimal CofinsV { get; set; }

    public int IpiCst { get; set; }

    public decimal IpiVbc { get; set; }

    public decimal IpiP { get; set; }

    public decimal IpiV { get; set; }

    public int IpiCenq { get; set; }

    public int IcmsCsosn { get; set; }

    public decimal IcmsVicmsstret { get; set; }

    public decimal IcmsPst { get; set; }

    public decimal IcmsVbcstret { get; set; }

    public decimal IcmsVbcstdest { get; set; }

    public decimal IcmsVicmsstdest { get; set; }

    public decimal IcmsPredbcefet { get; set; }

    public decimal IcmsVbcefet { get; set; }

    public decimal IcmsPicmsefet { get; set; }

    public decimal IcmsVicmsefet { get; set; }

    public decimal IcmsRedbc { get; set; }

    public decimal IiVbc { get; set; }

    public decimal IiDespadu { get; set; }

    public decimal IiVii { get; set; }

    public decimal IiViof { get; set; }

    public string? Sku { get; set; }

    public int? VinculadoPor { get; set; }

    public DateTime? VinculadoEm { get; set; }

    /// <summary>
    /// quantidade de um item por unidade comercial. Por exemplo: Se compramos 10 fardos de refrigerante e cada fardo tem 6 unidades de lata, a quantiade de 6 deve ser abastecida aqui.
    /// </summary>
    public decimal? QtdPorUnComercial { get; set; }

    public decimal? TotalCompradoUn { get; set; }

    public virtual TblIten? ItemNavigation { get; set; }

    public virtual TblNfEntradum NfEntrada { get; set; } = null!;
}
