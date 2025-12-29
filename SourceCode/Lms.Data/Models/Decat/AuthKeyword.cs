using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthKeyword
{
    public int? AuthNo { get; set; }

    public int? UniqueSfNo { get; set; }

    public string? KwKeyword { get; set; }

    public int? KwPosition { get; set; }

    public string? KwType { get; set; }
}
