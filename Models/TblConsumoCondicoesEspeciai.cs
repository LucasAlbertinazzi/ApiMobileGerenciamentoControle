using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblConsumoCondicoesEspeciai
{
    public int IdConsumoCe { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal Desconto { get; set; }

    public DateTime ValidadeInicio { get; set; }

    public DateTime? ValidadeFim { get; set; }

    public int? CriadoPor { get; set; }

    public DateTime CriadaEm { get; set; }
}
