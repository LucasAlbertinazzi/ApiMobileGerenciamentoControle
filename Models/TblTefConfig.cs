using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblTefConfig
{
    public int Empresa { get; set; }

    public string? Pdv1 { get; set; }

    public string? Pdv2 { get; set; }

    public string? IpTef { get; set; }

    public string? CnpjEmpresa { get; set; }

    public string? CnpjSofthouse { get; set; }

    public int? Codloja { get; set; }

    public string? SecretPix { get; set; }
}
