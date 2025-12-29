using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MeetingTypeDepartment
{
    public int MeetingTypeid { get; set; }

    public string? Description { get; set; }

    public int Visible { get; set; }

    public int Servicesid { get; set; }

    public virtual MeetingType MeetingType { get; set; } = null!;

    public virtual Service Services { get; set; } = null!;
}
