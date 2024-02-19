using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblContaEstoque
{
    public int Id { get; set; }

    public int? IdCategoria { get; set; }

    public string? IdGrupo { get; set; }

    public DateTime? DataAbre { get; set; }

    public DateTime? DataFecha { get; set; }

    public string? UserAbre { get; set; }

    public string? UserFecha { get; set; }

    public string? IdLocal { get; set; }

    public string? Excluir { get; set; }

    public string? UserExcluir { get; set; }

    public string? Finalizado { get; set; }

    public int? IdLista { get; set; }

    public string? Idcategorialista { get; set; }
}
