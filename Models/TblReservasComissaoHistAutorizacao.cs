using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblReservasComissaoHistAutorizacao
{
    public long IdComissaoHistAuto { get; set; }

    public int IdUsuario { get; set; }

    public string IdReservaCb { get; set; } = null!;

    public string Obs { get; set; } = null!;

    public decimal? ValorCb { get; set; }

    public decimal? ValorSistema { get; set; }

    public DateTime? AutorizadoEm { get; set; }
}
