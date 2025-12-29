using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacNice
{
    public string? OnDesc { get; set; }

    public string? OnWhere { get; set; }

    public int? OnTagNo { get; set; }

    public string? OnKwcode { get; set; }

    public string? OnAuthList { get; set; }

    public int? OnStkLimit { get; set; }

    public int? OnAuthLimit { get; set; }

    public string? OnBrowse { get; set; }

    public string? OnKeyword { get; set; }

    public string? OnBrDesc { get; set; }

    public string? OnBrStopList { get; set; }

    public string? OnBrAuthList { get; set; }

    public string? OnBrStkLines { get; set; }

    public string? OnBrAuthTags { get; set; }

    public string? OnKwDesc { get; set; }

    public string? OnKwAuthList { get; set; }

    public string? OnItemSeq { get; set; }

    public int? OnStats { get; set; }
}
