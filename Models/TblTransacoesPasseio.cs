using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblTransacoesPasseio
{
    public long IdPasseio { get; set; }

    public string Parceiro { get; set; } = null!;

    public string DescricaoTransacao { get; set; } = null!;
}
