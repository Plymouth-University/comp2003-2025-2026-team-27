using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class MeetingStatus
{
    public string MeetingStatusId { get; set; } = null!;

    public string? MeetingStatusDescription { get; set; }
}
