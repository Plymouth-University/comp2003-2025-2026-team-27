using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AEmailTemplate
{
    public string AName { get; set; } = null!;

    public string? AValue { get; set; }

    public string? TemplateSubject { get; set; }

    public int? ReportGroupId { get; set; }

    public string? DefaultEmail { get; set; }

    public bool? MultiplePart { get; set; }

    public string? AHeaderValue { get; set; }

    public string? AFooterValue { get; set; }

    public string? DefaultBccEmail { get; set; }
}
