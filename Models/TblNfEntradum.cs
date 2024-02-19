using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblNfEntradum
{
    public int IdNfEntrada { get; set; }

    public int NumeroNota { get; set; }

    public string ChaveAcesso { get; set; } = null!;

    public string CnpjEmitente { get; set; } = null!;

    public DateTime DataEmissao { get; set; }

    public decimal ValorTotalNf { get; set; }

    public decimal ValorTotalItem { get; set; }

    public string Xml { get; set; } = null!;

    public DateTime DataRegistro { get; set; }

    public int CodigoUsuario { get; set; }

    public int Serie { get; set; }

    public int Cuf { get; set; }

    public int Cnf { get; set; }

    public string Natop { get; set; } = null!;

    public int Mod { get; set; }

    public int Tpnf { get; set; }

    public int Iddest { get; set; }

    public int Cmunfg { get; set; }

    public int Tpimp { get; set; }

    public int Tpemis { get; set; }

    public int Tpamb { get; set; }

    public int Finnfe { get; set; }

    public int Indfinal { get; set; }

    public int Indpres { get; set; }

    public int Indintermed { get; set; }

    public int Procemi { get; set; }

    public string Verproc { get; set; } = null!;

    public int Cstat { get; set; }

    public string Motivo { get; set; } = null!;

    public string Nprot { get; set; } = null!;

    public DateTime DataRecebido { get; set; }

    public decimal TotalVbc { get; set; }

    public decimal TotalIcms { get; set; }

    public decimal TotalIcmsdeson { get; set; }

    public decimal TotalFcp { get; set; }

    public decimal TotalBcst { get; set; }

    public decimal TotalSt { get; set; }

    public decimal TotalFcpst { get; set; }

    public decimal TotalFrete { get; set; }

    public decimal TotalSeg { get; set; }

    public decimal TotalDesc { get; set; }

    public decimal TotalIi { get; set; }

    public decimal TotalIpi { get; set; }

    public decimal TotalIpidevol { get; set; }

    public decimal TotalPis { get; set; }

    public decimal TotalCofins { get; set; }

    public decimal TotalOutro { get; set; }

    public decimal TotalFcpufdest { get; set; }

    public decimal TotalIcmsufdest { get; set; }

    public decimal TotalIcmsufremet { get; set; }

    public int Cdv { get; set; }

    public virtual TblFornecedore CnpjEmitenteNavigation { get; set; } = null!;

    public virtual ICollection<TblNfEntradaItem> TblNfEntradaItems { get; set; } = new List<TblNfEntradaItem>();
}
