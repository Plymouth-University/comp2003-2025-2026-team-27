using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class TempCatMarcImportDetail
{
    public int UniqueId { get; set; }

    public int TagNo { get; set; }

    public string? Ind1 { get; set; }

    public string? Ind2 { get; set; }

    public string? Sf { get; set; }

    public string? SfData { get; set; }

    public int? CatRefId { get; set; }

    public int? StkImportGroup { get; set; }

    public bool? FromZ3950 { get; set; }
}
