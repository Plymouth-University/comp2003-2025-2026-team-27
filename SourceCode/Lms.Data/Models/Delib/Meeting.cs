using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Meeting
{
    public DateTime? MeetingStartDate { get; set; }

    public DateTime? MeetingEndDate { get; set; }

    public string MeetingDescription { get; set; } = null!;

    public string? MeetingStatus { get; set; }

    public string? MeetingTitle { get; set; }

    public string? MeetingBarcode { get; set; }

    public int MeetingId { get; set; }

    public int? RoomId { get; set; }

    public string? LlCode { get; set; }

    public virtual ICollection<MeetingDelegate> MeetingDelegates { get; set; } = new List<MeetingDelegate>();
}
