using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class CbReserva
{
    public string IdReservaCb { get; set; } = null!;

    public string? NomeHospede { get; set; }

    public DateTime DataInicio { get; set; }

    public DateTime DataFinal { get; set; }

    public DateTime DataCriacao { get; set; }

    public string? Fonte { get; set; }

    public string? NomeQuarto { get; set; }

    public decimal Total { get; set; }

    public string? Adultos { get; set; }

    public string? Criancas { get; set; }

    public string? IdHospedeCb { get; set; }

    public string? StatusHospede { get; set; }

    public string? TotalQuarto { get; set; }

    public int ItensAdicionaisBalanco { get; set; }

    public string? Status { get; set; }

    public DateTime DataRegistro { get; set; }
}
