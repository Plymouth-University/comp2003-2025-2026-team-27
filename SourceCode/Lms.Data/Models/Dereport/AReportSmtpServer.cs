using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportSmtpServer
{
    public int SmtpServerId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ClientHost { get; set; } = null!;

    public int ClientPort { get; set; }

    public bool RequireAuth { get; set; }

    public string? DefaultUser { get; set; }

    public string? DefaultPwd { get; set; }

    public bool? EnableSsl { get; set; }

    public virtual ICollection<AReportEmail> AReportEmails { get; set; } = new List<AReportEmail>();

    public virtual ICollection<AReport> AReports { get; set; } = new List<AReport>();
}
