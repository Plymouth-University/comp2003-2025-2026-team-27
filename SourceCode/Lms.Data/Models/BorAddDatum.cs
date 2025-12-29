using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorAddDatum
{
    public int BorNo { get; set; }

    public byte Rowid { get; set; }

    public byte Columnid { get; set; }

    public string? Stringvalue { get; set; }

    public DateTime? Datetimevalue { get; set; }

    public bool? Checkedvalue { get; set; }

    public int? Intvalue { get; set; }

    public string? TbColumnid { get; set; }
}
