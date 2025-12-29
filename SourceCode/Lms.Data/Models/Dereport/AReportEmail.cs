using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportEmail
{
    public int AReportEmailId { get; set; }

    public int AReport { get; set; }

    public int? SchedulerId { get; set; }

    /// <summary>
    /// The visible “real name” of the intended recipient of the email. Fill in the recipient’s real name. You should avoid characters like “&lt;” and “&gt;”.
    /// </summary>
    public string ToName { get; set; } = null!;

    /// <summary>
    /// Specify the destination email address.
    /// </summary>
    public string ToEmail { get; set; } = null!;

    /// <summary>
    /// The visible “real name” of the sender of the email. Fill in the sender’s real name. You should avoid characters like “&lt;” and “&gt;”.
    /// </summary>
    public string FromName { get; set; } = null!;

    /// <summary>
    /// Specify the source email address.
    /// </summary>
    public string FromEmail { get; set; } = null!;

    /// <summary>
    /// The subject of the email.
    /// </summary>
    public string Subject { get; set; } = null!;

    /// <summary>
    /// Specifies the filenames of attachments to be included. The files must exist in the directory configured by the AttachFileDir setting in the config.ini. If one is missing the email will fail. These documents will be deleted once the email is sent. Names must be separated by a semi-colon (“;”).
    /// </summary>
    public string? AttachFileNames { get; set; }

    /// <summary>
    /// The body text used when sending a plain text only email. Ignored when sending HTML emails. If IS_ICALENDAR (see below) is set to 1 this field contains the text representing the appointment being sent, in compliance with RFC2445. 
    /// </summary>
    public string? BodyText { get; set; }

    /// <summary>
    /// The HTML code used to send when sending an HTML email. The plaint text version of the email will be generated from this code. This field is ignored when sending a plain text only email.
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// Status of the email request. Can contain one of the following values:
    /// </summary>
    public string? EmailStatus { get; set; }

    /// <summary>
    /// The date and time the request record was inserted in to the table. Should be populated by the calling application.
    /// </summary>
    public DateTime DateTimeRequest { get; set; }

    /// <summary>
    /// The date and time that the Email Sender processed the request.
    /// </summary>
    public DateTime? DateTimeSent { get; set; }

    /// <summary>
    /// The application user or module that placed the request. Can be free text, if not required just fill with an arbitrary string of your choice.
    /// </summary>
    public string EmailSentBy { get; set; } = null!;

    /// <summary>
    /// The normally invisible warning text that is shown when a MIME email (i.e. an HTML or one with attachments) is viewed in a non-MIME email client.
    /// </summary>
    public string? NonMimeWarning { get; set; }

    /// <summary>
    /// Comma separated list of email addresses to Cc the email to. If you want to include real names in this list use the following format:
    /// </summary>
    public string? CcEmail { get; set; }

    /// <summary>
    /// Comma separated list of email addresses to Bcc the email to. If you want to include real names in this list use the following format:
    /// </summary>
    public string? BccEmail { get; set; }

    /// <summary>
    /// A Boolean flag to indicate whether this email should be sent using HTML (and hence the text from BODY_HTML) or plain text (BODY_TEXT is then used). Valid value are 0 for plain text and 1 for HTML.
    /// </summary>
    public bool SendHtml { get; set; }

    /// <summary>
    /// A Boolean flag to indicate whether this email has attachments. If this field contains a 1 the ATTACH_FILE_NAMES column is parsed to figure out the filenames. If this column contains a 0 (default) then the ATTACH_FILE_NAMES column is ignored.
    /// </summary>
    public bool AddAttachments { get; set; }

    /// <summary>
    /// Set this column to indicate that this email should be a specially formatted one used to send appointments to PIM applications (Outlook et al). Before using this setting we recommend that you become familiar with the Internet standard on iCalendar (RFCs 2445, 2446 and 2447). When this is set to 1 only BODY_TEXT, the addressing fields, ICAL_MIME and subject field are used when creating the email – all others are ignored. The ICAL_MIME field MUST also be filled in with the correct value (see RFC 2447) for the iCalendar object you are sending.
    /// </summary>
    public bool IsIcalendar { get; set; }

    /// <summary>
    /// This field must be filled in with the additional section required by the iCalendar protocol (RFC 2447). This field represents the “method=xyz” part of the content type header. This field will be ignored unless IS_ICALENDAR (above) is set to 1.
    /// </summary>
    public string? IcalMime { get; set; }

    /// <summary>
    /// This is the date time when you want to send this email out. If you want to send it out as soon as possible so we set it NULL or the time in the past.
    /// </summary>
    public DateTime? DateTimeDelivery { get; set; }

    /// <summary>
    /// Set to 1 to enable a “read receipt” for the email that is sent. The read notification will get sent back to the email address in the FROM_EMAIL field
    /// </summary>
    public bool ReadReceipt { get; set; }

    public string? ErrorLog { get; set; }

    /// <summary>
    /// Set to 1 to enable a &quot;delivery receipt&quot; for the email that is sent. Will get sent back to the email address in the FROM_EMAIL field
    /// </summary>
    public bool DeliveryReceipt { get; set; }

    /// <summary>
    /// Foreign key for A_REPORT_SMTP_SERVER.
    /// </summary>
    public int? SmtpServerId { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;

    public virtual AScheduler? Scheduler { get; set; }

    public virtual AReportSmtpServer? SmtpServer { get; set; }
}
