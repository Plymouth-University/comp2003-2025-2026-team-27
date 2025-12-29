using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MeetingType
{
    public int MeetingTypesid { get; set; }

    public string? Description { get; set; }

    public string? Colour { get; set; }

    public int? Orderid { get; set; }

    public int? Visible { get; set; }

    public int Servicesid { get; set; }

    public virtual ICollection<AppointmentTag> AppointmentTags { get; set; } = new List<AppointmentTag>();

    public virtual ICollection<MeetingTypeDepartment> MeetingTypeDepartments { get; set; } = new List<MeetingTypeDepartment>();
}
