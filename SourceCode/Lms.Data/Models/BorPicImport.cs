using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorPicImport
{
    public int? BpiFileNo { get; set; }

    public string? BpiImportKey { get; set; }

    public string? BpiFileName { get; set; }
}
