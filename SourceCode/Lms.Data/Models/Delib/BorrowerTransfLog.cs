using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorrowerTransfLog
{
    public string BorBarNo { get; set; } = null!;

    public string? OperName { get; set; }

    public string? StatusMessage { get; set; }

    public DateTime DateTimeProcess { get; set; }

    public string Status { get; set; } = null!;

    public string LibGroup { get; set; } = null!;

    public string LlCode { get; set; } = null!;

    public string ErrorNo { get; set; } = null!;
}
