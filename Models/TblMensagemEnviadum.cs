using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblMensagemEnviadum
{
    public int? Codreme { get; set; }

    public int? Coddest { get; set; }

    public string? Assunto { get; set; }

    public string? Mensagem { get; set; }

    public TimeOnly? Data { get; set; }

    public char? Lida { get; set; }

    public char? Arquivar { get; set; }

    public string? Destinatarios { get; set; }

    public char? Novo { get; set; }

    public char? Lixeira { get; set; }

    public char? Excluido { get; set; }

    public int? Codmensagemenv { get; set; }

    public char? Enviado { get; set; }

    public char? Anexo { get; set; }

    public char? Encresp { get; set; }

    public char? Rascunho { get; set; }

    public int? Vincmsg { get; set; }

    public int? Encaminhada { get; set; }

    public int Codigo { get; set; }
}
