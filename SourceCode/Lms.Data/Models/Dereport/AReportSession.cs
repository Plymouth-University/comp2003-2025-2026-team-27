using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportSession
{
    public string? SessionId { get; set; }

    public string? ReportName { get; set; }

    public string? SqlSelect { get; set; }

    public string? Formats { get; set; }

    public string? InputItems { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? DatabaseName { get; set; }

    public string? Filename { get; set; }

    public string? FileFormat { get; set; }
}
