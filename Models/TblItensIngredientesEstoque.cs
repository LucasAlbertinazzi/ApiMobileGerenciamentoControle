using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblItensIngredientesEstoque
{
    public int IdIngrediente { get; set; }

    public string Local { get; set; } = null!;

    public int? IdUnIngrediente { get; set; }

    public decimal? Qtd { get; set; }
}
