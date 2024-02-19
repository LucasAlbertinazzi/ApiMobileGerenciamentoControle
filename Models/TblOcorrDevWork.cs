using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblOcorrDevWork
{
    public int Id { get; set; }

    public int? Numerochamado { get; set; }

    public int? Codusuario { get; set; }

    public TimeSpan? TempoDev { get; set; }

    public DateTime? DataDev { get; set; }
}
