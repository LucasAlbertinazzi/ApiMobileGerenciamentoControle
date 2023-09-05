using System;
using System.Collections.Generic;

namespace API_AppPousada_ControleEstoque.Models;

public partial class AuditLog
{
    public string TableName { get; set; } = null!;

    public string Operation { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string? OldData { get; set; }

    public string? NewData { get; set; }

    public int Id { get; set; }
}
