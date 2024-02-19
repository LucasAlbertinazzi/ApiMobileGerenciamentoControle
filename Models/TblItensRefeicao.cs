using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

/// <summary>
/// tabela com os preços fixos da refeição completa e refeição kids.
/// </summary>
public partial class TblItensRefeicao
{
    public int IdRefeicao { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco { get; set; }
}
