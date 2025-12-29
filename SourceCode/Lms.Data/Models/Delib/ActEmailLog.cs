using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ActEmailLog
{
    public int ActEmailLog1 { get; set; }

    public string? ToName { get; set; }

    public string? ToEmail { get; set; }

    public string? FromName { get; set; }

    public string? FromEmail { get; set; }

    public string? Subject { get; set; }

    public int? NumbAttach { get; set; }

    public string? AttachFileNames { get; set; }

    public string? BodyText { get; set; }

    public string? EmailStatus { get; set; }

    public DateTime DateTimeRequest { get; set; }

    public DateTime? DateTimeSent { get; set; }

    public string? EmailSentBy { get; set; }

    public string? NonMimeWarning { get; set; }

    public string? CcEmail { get; set; }

    public int? SendHtml { get; set; }

    public string? BodyHtml { get; set; }

    public string? BccEmail { get; set; }

    public int? AddAttachments { get; set; }

    public int? IsIcalendar { get; set; }

    public string? IcalMime { get; set; }

    public int? ReadReceipt { get; set; }

    public DateTime? DateTimeDelivery { get; set; }

    public string? LastUpDate { get; set; }
}
