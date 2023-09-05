﻿using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// tipos possíveis de unidade de um ingrediente
/// </summary>
public partial class TblItensIngredientesUnidade
{
    public int IdUnIngrediente { get; set; }

    public string? Descricao { get; set; }

    public string? Abrev { get; set; }
}