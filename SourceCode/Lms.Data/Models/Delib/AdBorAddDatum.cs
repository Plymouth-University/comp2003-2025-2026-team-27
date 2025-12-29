using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AdBorAddDatum
{
    public int BorNo { get; set; }

    public int Rowid { get; set; }

    public int Columnid { get; set; }

    public string? Stringvalue { get; set; }

    public DateTime? Datetimevalue { get; set; }

    public bool? Checkedvalue { get; set; }

    public int? Intvalue { get; set; }

    public string? Actiontype { get; set; }

    public DateTime? Actiontime { get; set; }

    public string? TbColumnid { get; set; }
}
