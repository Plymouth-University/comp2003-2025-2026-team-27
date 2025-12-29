using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorAddDataConfig
{
    public byte Rowid { get; set; }

    public byte Columnid { get; set; }

    public byte Placeholdertypeid { get; set; }

    public string? Label { get; set; }

    public byte? Editdatatype { get; set; }

    public byte? Ddltablenum { get; set; }

    public bool? Checkedbydefault { get; set; }

    public string? TbColumnid { get; set; }

    public string BorType { get; set; } = null!;

    public string BorGroups { get; set; } = null!;

    public string BorClasses { get; set; } = null!;
}
