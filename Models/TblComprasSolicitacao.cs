using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblComprasSolicitacao
{
    public int IdCompraSolicitacao { get; set; }

    public int SolicitadoPor { get; set; }

    public DateTime SolicitadoEm { get; set; }

    public bool Finalizada { get; set; }
}
