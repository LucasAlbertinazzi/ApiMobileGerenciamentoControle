using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblConsumoImpressaoCozinha
{
    public long IdImpressaoCozinha { get; set; }

    public int? IdMesa { get; set; }

    public string? Tipo { get; set; }

    public string? Documento { get; set; }

    public bool Impresso { get; set; }

    public string? TipoImpressao { get; set; }

    public DateTime? Data { get; set; }

    public int? IdUsuario { get; set; }
}
