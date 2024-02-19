using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class TblCloudbedsToken
{
    public int Id { get; set; }

    public string AccessToken { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public string TokenType { get; set; } = null!;

    public int Expires { get; set; }

    public DateTime Created { get; set; }
}
