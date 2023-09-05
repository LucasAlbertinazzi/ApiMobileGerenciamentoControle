using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblOcorrChamadosReag
{
    public int CodReag { get; set; }

    public int? Codigo { get; set; }

    public DateTime? DataReag { get; set; }

    public DateTime? DataAntiga { get; set; }

    public DateTime? DataNova { get; set; }

    public int? Usuario { get; set; }

    public bool Reaberto { get; set; }
}
