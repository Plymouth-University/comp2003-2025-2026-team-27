using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AdBorAddDataConfig
{
    public byte? Rowid { get; set; }

    public byte? Columnid { get; set; }

    public byte? Placeholdertypeid { get; set; }

    public string? Label { get; set; }

    public byte? Editdatatype { get; set; }

    public byte? Ddltablenum { get; set; }

    public bool? Checkedbydefault { get; set; }

    public string? Actiontype { get; set; }

    public DateTime? Actiontime { get; set; }

    public string? TbColumnid { get; set; }

    public string? BorType { get; set; }

    public string? BorGroups { get; set; }

    public string BorClasses { get; set; } = null!;
}
