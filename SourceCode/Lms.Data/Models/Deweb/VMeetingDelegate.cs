using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VMeetingDelegate
{
    public int MeetingId { get; set; }

    public int BorNo { get; set; }

    public string? DelegateType { get; set; }

    public int MeetingDelegateStatus { get; set; }

    public DateTime? CheckInTime { get; set; }

    public DateTime? CheckOutTime { get; set; }

    public string? CarRegistration { get; set; }

    public string? UserMeetingBarcode { get; set; }
}
