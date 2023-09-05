using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblHospede
{
    public long IdHospede { get; set; }

    public string? IdHospedeCb { get; set; }

    public string? Nome { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public DateTime DataCriacao { get; set; }

    public DateTime DataModificacao { get; set; }

    public string? Cpf { get; set; }

    public string? Celular { get; set; }

    public DateTime DataRegistro { get; set; }

    public int? CadastradoPor { get; set; }

    public DateTime? CadastradoEm { get; set; }

    public int? ModificadoPor { get; set; }

    public bool Vegano { get; set; }

    public bool Vegetariano { get; set; }

    public bool IntoleranteLactose { get; set; }

    public bool IntoleranteGluten { get; set; }

    public string? OutrasRestricoesAlim { get; set; }

    public DateOnly? DataNascimento { get; set; }

    public string? Apelido { get; set; }

    public string? Profissao { get; set; }

    public string? Escola { get; set; }

    public string? OutrasRestricoes { get; set; }
}
