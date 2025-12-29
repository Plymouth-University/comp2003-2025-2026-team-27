using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class SysPasswordValidation
{
    public int Id { get; set; }

    public string MessageId { get; set; } = null!;

    public string ValidDesc { get; set; } = null!;

    public string ValidRegex { get; set; } = null!;

    public string? JavascriptRegex { get; set; }

    public string? ErrorMsg { get; set; }

    public string? MsgDisplayStatus { get; set; }
}
