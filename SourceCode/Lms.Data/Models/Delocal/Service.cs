using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Service
{
    public int Servicesid { get; set; }

    public string? BgGroup { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceSummary { get; set; }

    public string? ImageUrl { get; set; }

    public string? Phone { get; set; }

    public string? ServiceAddress { get; set; }

    public int MajorService { get; set; }

    public string? EmailAddress { get; set; }

    public virtual BorGroup? BgGroupNavigation { get; set; }

    public virtual ICollection<MeetingTypeDepartment> MeetingTypeDepartments { get; set; } = new List<MeetingTypeDepartment>();
}
