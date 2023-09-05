using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class TblTransaco
{
    public long IdTransacao { get; set; }

    public string? IdTransacaoCb { get; set; }

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

    public int? Vendedor { get; set; }

    public int? IdDivTerc { get; set; }

    public string? Sku { get; set; }

    public string? IdLocal { get; set; }

    public bool Excluido { get; set; }

    public int? ExcluidoPor { get; set; }

    public DateTime? ExcluidoEm { get; set; }
}
