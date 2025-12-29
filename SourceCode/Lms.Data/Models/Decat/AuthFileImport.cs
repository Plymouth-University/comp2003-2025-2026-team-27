using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthFileImport
{
    public int? AfiNo { get; set; }

    public string? AfiLeader { get; set; }

    public int? AfiDeleted { get; set; }

    public int? AfiRecord { get; set; }

    public int? AfiType { get; set; }

    public string? AfiCurrStk { get; set; }

    public string? AfiCurrStkNext { get; set; }

    public string? AfiOrigStk { get; set; }

    public string? AfiOrigStkNext { get; set; }

    public string? AfiDeprComments { get; set; }

    public int? AfiCurrentFlags { get; set; }

    public int? AfiAuthNo { get; set; }

    public int? AfiCatNo { get; set; }

    public int? AfiData { get; set; }

    public int? AfiUserSerial { get; set; }

    public DateTime? AfiDate { get; set; }

    public string? AfiOriginal { get; set; }
}
