using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AClientReport
{
    public int AReport { get; set; }

    public int ClientNumber { get; set; }

    public int? ADefaultProfile { get; set; }

    public virtual AProfile? ADefaultProfileNavigation { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;

    public virtual Client ClientNumberNavigation { get; set; } = null!;

    public virtual ICollection<AAnsUser> AAnsUsers { get; set; } = new List<AAnsUser>();
}
