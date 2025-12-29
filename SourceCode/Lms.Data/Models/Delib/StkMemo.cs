using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkMemo
{
    public int? SmUniqueItemNo { get; set; }

    public DateTime? SmEffDate { get; set; }

    public string? SmDisplay { get; set; }

    public string? SmData { get; set; }

    public string? SmType { get; set; }

    public string? SmBorBarNo { get; set; }

    public string? SmStkItemNo { get; set; }

    public string? SmUniqueNo { get; set; }

    public DateTime? SmEndDate { get; set; }
}
