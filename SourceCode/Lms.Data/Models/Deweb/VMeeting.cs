using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VMeeting
{
    public int MeetingId { get; set; }

    public string? MeetingTitle { get; set; }

    public DateTime? MeetingStartDate { get; set; }

    public DateTime? MeetingEndDate { get; set; }

    public string MeetingDescription { get; set; } = null!;

    public string? MeetingStatus { get; set; }

    public string? LlCode { get; set; }

    public string? MeetingBarcode { get; set; }

    public int? RoomId { get; set; }
}
