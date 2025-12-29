using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipSchemeValue
{
    public int? NsvId { get; set; }

    public int? NsvSchemeId { get; set; }

    public string? NsvValue { get; set; }

    public string? NsvDesc { get; set; }
}
