using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class ErrorLogsController
{
    public long Id { get; set; }

    public string? From { get; set; }

    public string? Message { get; set; }

    public string? InnerException { get; set; }

    public DateTime DataErro { get; set; }

    public string? Json { get; set; }
}
