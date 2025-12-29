using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ABorSearch
{
    public long SsId { get; set; }

    public long SearchId { get; set; }

    public string Keyword { get; set; } = null!;

    public string? Parameter { get; set; }

    public int? Type { get; set; }

    public string? Operator { get; set; }

    public string? Location { get; set; }

    public string? LocationName { get; set; }

    public int? Etype { get; set; }

    public string? Result { get; set; }

    public virtual ABorSavedSearch Ss { get; set; } = null!;
}
