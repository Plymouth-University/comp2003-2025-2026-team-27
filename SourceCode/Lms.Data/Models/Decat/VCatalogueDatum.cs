using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class VCatalogueDatum
{
    public int? CatNo { get; set; }

    public int? UniqueNo { get; set; }

    public int? TagNo { get; set; }

    public string? Sf { get; set; }

    public string? SfData { get; set; }

    public int? SfSequence { get; set; }

    public int? CatSfLongNo { get; set; }

    public string? ClData { get; set; }

    public string? ClDataText { get; set; }

    public int Authority { get; set; }

    public int Id { get; set; }
}
