using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorFileMap
{
    public string? BfmColumn { get; set; }

    public string? BfmImportCode { get; set; }

    public string? BfmAmlibCode { get; set; }

    public DateTime? BfmDateCreated { get; set; }
}
