using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class MeetingDelegate
{
    public int MeetingId { get; set; }

    public int BorNo { get; set; }

    public string? CarRegistration { get; set; }

    public string? UserMeetingBarcode { get; set; }

    public string? DelegateType { get; set; }

    public int CStatus { get; set; }

    public DateTime? CheckInTime { get; set; }

    public DateTime? CheckOutTime { get; set; }

    public virtual Meeting Meeting { get; set; } = null!;
}
