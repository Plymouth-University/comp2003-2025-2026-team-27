using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class MostPopularCatalogue
{
    public string StkLibGroup { get; set; } = null!;

    public string StkLocPerm { get; set; } = null!;

    public string StkFormType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Threshold { get; set; }

    public int CatNo { get; set; }

    public string? CatStr1 { get; set; }

    public string? CatStr2 { get; set; }

    public string? CatStr3 { get; set; }

    public string? CatStr4 { get; set; }

    public byte[]? CatPicData { get; set; }

    public int? IssuesNum { get; set; }
}
