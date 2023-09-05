using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// local em que o item está.
/// 
/// Se o item não for físico, é serviço
/// </summary>
public partial class TblItensLocal
{
    public string IdLocal { get; set; } = null!;

    public string Local { get; set; } = null!;

    public bool? Fisico { get; set; }

    public bool PontoVenda { get; set; }

    public bool UsoPousada { get; set; }
}
