using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagFixedParam
{
    public int? TfpUniqueNo { get; set; }

    public int? TfpTagno { get; set; }

    public string? TfpMaterialType { get; set; }

    public int? TfpPos { get; set; }

    public int? TfpLength { get; set; }

    public string? TfpDesc { get; set; }

    public int? TfpOptionSeq { get; set; }

    public string? TfpOptionCode { get; set; }

    public string? TfpOptionDesc { get; set; }

    public int? TfpYearfr { get; set; }

    public int? TfpYearto { get; set; }
}
