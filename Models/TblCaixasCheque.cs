using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblCaixasCheque
{
    public long IdCheque { get; set; }

    public long IdReserva { get; set; }

    public decimal Valor { get; set; }

    public string Banco { get; set; } = null!;

    public string Agencia { get; set; } = null!;

    public string Conta { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public DateTime Vencimento { get; set; }

    public bool Predatado { get; set; }

    public int CadastradoPor { get; set; }

    public long IdCaixa { get; set; }

    public virtual TblUsuario CadastradoPorNavigation { get; set; } = null!;

    public virtual TblCaixa IdCaixaNavigation { get; set; } = null!;

    public virtual TblReserva IdReservaNavigation { get; set; } = null!;
}
