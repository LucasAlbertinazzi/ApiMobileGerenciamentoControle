using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

/// <summary>
/// dados das pousadas
/// </summary>
public partial class TblPousada
{
    public int IdPousada { get; set; }

    public string? Cnpj { get; set; }

    public string? Ie { get; set; }

    public string? NomeFantasia { get; set; }

    public string? NomeEmpresarial { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }
}
