using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ActEmailLog
{
    public int ActEmailLog1 { get; set; }

    public string ToName { get; set; } = null!;

    public string ToEmail { get; set; } = null!;

    public string FromName { get; set; } = null!;

    public string FromEmail { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public int? NumbAttach { get; set; }

    public byte[]? AttachFileNames { get; set; }

    public byte[]? BodyText { get; set; }

    public string? EmailStatus { get; set; }

    public DateTime DateTimeRequest { get; set; }

    public DateTime? DateTimeSent { get; set; }

    public string EmailSentBy { get; set; } = null!;

    public string? NonMimeWarning { get; set; }

    public byte[]? CcEmail { get; set; }

    public int SendHtml { get; set; }

    public byte[]? BodyHtml { get; set; }

    public byte[]? BccEmail { get; set; }

    public int AddAttachments { get; set; }

    public int IsIcalendar { get; set; }

    public string? IcalMime { get; set; }

    public int ReadReceipt { get; set; }
}
