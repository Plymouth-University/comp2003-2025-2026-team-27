using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthFileImportList
{
    public int? AfilNo { get; set; }

    public string? AfilList { get; set; }

    public int? AfilUserSerial { get; set; }

    public DateTime? AfilDate { get; set; }

    public string? AfilOriginal { get; set; }
}
