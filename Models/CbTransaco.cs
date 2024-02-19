using System;
using System.Collections.Generic;

namespace API_GerenciamentoGerenciamentoControle_Controle.Models;

public partial class CbTransaco
{
    public string IdTransacaoCb { get; set; } = null!;

    public string? Descricao { get; set; }

    public decimal Valor { get; set; }

    public int Quantidade { get; set; }

    public string? NomeCliente { get; set; }

    public string? NomeQuarto { get; set; }

    public string? NomeUsuario { get; set; }

    public string? Categoria { get; set; }

    public string? Tipo { get; set; }

    public DateTime Data { get; set; }

    public string? Notas { get; set; }

    public string? IdReservaCb { get; set; }

    public string? IdHospedeCb { get; set; }

    public DateTime DataRegistro { get; set; }
}
