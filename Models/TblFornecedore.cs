using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblFornecedore
{
    public string? NomeFantasia { get; set; }

    public string RazaoSocial { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public string? InscricaoEstadual { get; set; }

    public string? InscricaoMunicipal { get; set; }

    public string? NomeContato { get; set; }

    public string? Celular { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Pais { get; set; }

    public string? Obs { get; set; }

    public DateTime CadastradoEm { get; set; }

    public int CadastradoPor { get; set; }

    public DateTime? AtualizadoEm { get; set; }

    public int? AtualizadoPor { get; set; }

    public bool? Ativo { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Cep { get; set; }

    public string? Uf { get; set; }

    public string? Site { get; set; }

    public string? ChavePix { get; set; }

    public bool PessoaFisica { get; set; }

    public virtual TblUsuario? AtualizadoPorNavigation { get; set; }

    public virtual TblUsuario CadastradoPorNavigation { get; set; } = null!;

    public virtual ICollection<TblNfEntradum> TblNfEntrada { get; set; } = new List<TblNfEntradum>();
}
