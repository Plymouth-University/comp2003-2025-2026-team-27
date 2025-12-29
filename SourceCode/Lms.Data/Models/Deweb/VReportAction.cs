using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VReportAction
{
    public int? CatNo { get; set; }

    public int? UniqueNo { get; set; }

    public int? SfSequence { get; set; }

    public string? ActionInfo { get; set; }

    public string? ActionLabel { get; set; }
}
