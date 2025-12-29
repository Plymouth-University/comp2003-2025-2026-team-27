using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class FileCatName
{
    public int? FileNumber { get; set; }

    public string? FileOper { get; set; }

    public DateTime? FileDate { get; set; }

    public string? FileType { get; set; }

    public int? FileQty { get; set; }

    public string? FileDesc { get; set; }

    public string? FileKey { get; set; }

    public string? FileOperAccess { get; set; }

    public int? FileMaxSequence { get; set; }

    public string? ListType { get; set; }
}
