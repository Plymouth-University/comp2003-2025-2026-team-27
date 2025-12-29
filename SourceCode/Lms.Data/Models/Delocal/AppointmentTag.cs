using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AppointmentTag
{
    public int AppointmentTagsid { get; set; }

    public int MeetingTypesid { get; set; }

    public string? Description { get; set; }

    public int? DeleteFlag { get; set; }

    public string? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public virtual MeetingType MeetingTypes { get; set; } = null!;
}
