using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class ImportLog
{
    public int LogId { get; set; }

    public DateTime LogDatetime { get; set; }

    public byte[] LogMarc { get; set; } = null!;

    public string LogOperName { get; set; } = null!;

    public string? LogMessage { get; set; }

    public string? LogImportFileName { get; set; }
}
