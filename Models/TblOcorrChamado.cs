using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblOcorrChamado
{
    public int Codigo { get; set; }

    public short? Coddepartamento { get; set; }

    public short? Codtiposervico { get; set; }

    public int? Patrimonio { get; set; }

    public int? Userchamado { get; set; }

    public int? Useracompanha { get; set; }

    public short? Ramal { get; set; }

    public DateTime? Datachamado { get; set; }

    public DateTime? Dataencerrado { get; set; }

    public DateOnly? Dataexecucao { get; set; }

    public string? Obs { get; set; }

    public bool? Recebido { get; set; }

    public DateTime? Previsao { get; set; }

    public short? Userexecuta { get; set; }

    public string? Obsfechamento { get; set; }

    public long? Codassistencia { get; set; }

    public DateTime? Retornoassistencia { get; set; }

    public long? UserPrioridade { get; set; }

    public short? Prioridade { get; set; }

    public bool? Planejamento { get; set; }

    public string? MetodoReferencia { get; set; }

    public string? Anotacao { get; set; }

    public char? Origem { get; set; }

    public string? Anexoos { get; set; }
}
