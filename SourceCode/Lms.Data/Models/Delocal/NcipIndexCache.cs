using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipIndexCache
{
    public string? NicId { get; set; }

    public string? NicItem { get; set; }

    public string? NicIndexes { get; set; }

    public int? NicOrder { get; set; }
}
