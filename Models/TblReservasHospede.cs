using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblReservasHospede
{
    public string IdReserva { get; set; } = null!;

    public long IdHospede { get; set; }
}
