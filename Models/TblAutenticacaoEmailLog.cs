using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblAutenticacaoEmailLog
{
    public int Id { get; set; }

    public int? Idusuario { get; set; }

    public string? Codigogerado { get; set; }

    public string? Emailuser { get; set; }

    public DateTime? Data { get; set; }

    public string? Text { get; set; }
}
