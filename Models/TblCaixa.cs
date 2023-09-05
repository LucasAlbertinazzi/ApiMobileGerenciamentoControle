using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblCaixa
{
    public long IdCaixa { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime DataCriacao { get; set; }

    public int CriadoPor { get; set; }

    public string? Banco { get; set; }

    public string? Agencia { get; set; }

    public string? ContaCorrente { get; set; }

    public string? Nome { get; set; }

    public string? Usuario { get; set; }

    public string? SenhaConta { get; set; }

    public string? ChavePix { get; set; }

    public string? Observacao { get; set; }

    public string? SenhaChave { get; set; }

    public string? SenhaSeisDigitos { get; set; }

    public string? Site { get; set; }

    public virtual TblUsuario CriadoPorNavigation { get; set; } = null!;

    public virtual ICollection<TblCaixasCheque> TblCaixasCheques { get; set; } = new List<TblCaixasCheque>();
}
