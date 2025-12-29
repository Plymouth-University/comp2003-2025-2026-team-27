using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagItemdef
{
    public string? TiMarcType { get; set; }

    public string? TiLoadType { get; set; }

    public int? TiUnique { get; set; }

    public int? TiTagNo { get; set; }

    public string? TiSubfield { get; set; }

    public int? TiOffset { get; set; }

    public int? TiLength { get; set; }

    public string? TiMarcVerify { get; set; }
}
