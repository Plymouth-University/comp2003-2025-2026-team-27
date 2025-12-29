using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorImportFormat
{
    public int TemplateId { get; set; }

    public bool? CurrentTemplate { get; set; }

    public string TemplateDesc { get; set; } = null!;
}
