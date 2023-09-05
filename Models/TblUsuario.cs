using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblUsuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string? Email { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime DataCadastro { get; set; }

    public bool Ativo { get; set; }

    public string? Cpf { get; set; }

    public int? IdFuncao { get; set; }

    public string? IdLocal { get; set; }

    public bool Alterarsenha { get; set; }

    public bool Bloqueado { get; set; }

    public string? CriadoPor { get; set; }

    public bool PermissaoEspecial { get; set; }

    public virtual ICollection<TblCaixa> TblCaixas { get; set; } = new List<TblCaixa>();

    public virtual ICollection<TblCaixasCheque> TblCaixasCheques { get; set; } = new List<TblCaixasCheque>();

    public virtual ICollection<TblConsumoMesaHist> TblConsumoMesaHistAbertaPorNavigations { get; set; } = new List<TblConsumoMesaHist>();

    public virtual ICollection<TblConsumoMesaHist> TblConsumoMesaHistFechadaPorNavigations { get; set; } = new List<TblConsumoMesaHist>();

    public virtual ICollection<TblFornecedore> TblFornecedoreAtualizadoPorNavigations { get; set; } = new List<TblFornecedore>();

    public virtual ICollection<TblFornecedore> TblFornecedoreCadastradoPorNavigations { get; set; } = new List<TblFornecedore>();

    public virtual ICollection<TblIten> TblItenAtualizadoPorNavigations { get; set; } = new List<TblIten>();

    public virtual ICollection<TblIten> TblItenCadastradoPorNavigations { get; set; } = new List<TblIten>();

    public virtual ICollection<TblItens2Grupo> TblItens2Grupos { get; set; } = new List<TblItens2Grupo>();

    public virtual ICollection<TblRecebimento> TblRecebimentos { get; set; } = new List<TblRecebimento>();

    public virtual ICollection<TblReserva> TblReservas { get; set; } = new List<TblReserva>();

    public virtual ICollection<TblSessoesUsuario> TblSessoesUsuarios { get; set; } = new List<TblSessoesUsuario>();
}
