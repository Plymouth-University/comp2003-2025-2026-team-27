using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CiSfDatum
{
    public int? SfAuthNo { get; set; }

    public string? Sf { get; set; }

    public int? SfSequence { get; set; }

    public int? SfUniqueNo { get; set; }

    public string? SfData { get; set; }

    public string? SfDiacritic { get; set; }
}
