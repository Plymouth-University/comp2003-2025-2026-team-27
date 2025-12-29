using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReport
{
    public int AReport1 { get; set; }

    public int AReportGroup { get; set; }

    public string? ReportName { get; set; }

    public string? ReportDesc { get; set; }

    public string? Definition { get; set; }

    public string? ReportQrp { get; set; }

    public string? ReportCrystal { get; set; }

    public string? Delimiter { get; set; }

    public string? Separator { get; set; }

    public string? Crlf { get; set; }

    public string? DateFormat { get; set; }

    public short? Graphical { get; set; }

    public string? ReportTypeDef { get; set; }

    public string? WordTemplate { get; set; }

    public string? Bookmark { get; set; }

    public string? Switcher { get; set; }

    public string? NamingKey { get; set; }

    public string? NamingPrefix { get; set; }

    public string? MailFields { get; set; }

    public string? BookField { get; set; }

    public string? TargetDatabase { get; set; }

    public int? Priority { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public short? CsvOverwrite { get; set; }

    public short? BatchSeqNo { get; set; }

    public string? CsvFilename { get; set; }

    public string? XmlFilename { get; set; }

    public string? StoredProc { get; set; }

    public string? ProcParams { get; set; }

    public string? PreStoredProc { get; set; }

    public string? PostStoredProc { get; set; }

    public int? StandardTextId { get; set; }

    public string? MailTo { get; set; }

    public string? MailFrom { get; set; }

    public int? DeleteFlag { get; set; }

    public string? CsvHeader { get; set; }

    public string? MailmergeFile { get; set; }

    public int? ADatabase { get; set; }

    public int? ClientBaseReport { get; set; }

    public string? DistinctFlag { get; set; }

    public bool? FreeHandSqlFlag { get; set; }

    public int? PositionInGroup { get; set; }

    public bool? ReportTemplateFlag { get; set; }

    public string? DefaultEmailSubject { get; set; }

    public bool? EmailFlag { get; set; }

    public bool? EmailReadReceipt { get; set; }

    public bool? EmailDeliveryReceipt { get; set; }

    public int? SmtpServerId { get; set; }

    public bool? SystemReport { get; set; }

    public bool? TableViewFlag { get; set; }

    public string? RepQrpTitle1 { get; set; }

    public string? RepQrpTitle2 { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int? ImportId { get; set; }

    public string? EmailTemplate { get; set; }

    public int? AuthLevel { get; set; }

    public bool? PassParamsToQrp { get; set; }

    public virtual ICollection<AClientReport> AClientReports { get; set; } = new List<AClientReport>();

    public virtual ICollection<AEmailRptAttachment> AEmailRptAttachments { get; set; } = new List<AEmailRptAttachment>();

    public virtual ICollection<AReportBatchRp> AReportBatchRps { get; set; } = new List<AReportBatchRp>();

    public virtual ICollection<AReportColumnAlias> AReportColumnAliases { get; set; } = new List<AReportColumnAlias>();

    public virtual ICollection<AReportEmail> AReportEmails { get; set; } = new List<AReportEmail>();

    public virtual AReportGroup AReportGroupNavigation { get; set; } = null!;

    public virtual ICollection<AReportParam> AReportParams { get; set; } = new List<AReportParam>();

    public virtual ICollection<AReportSchPostStoreProc> AReportSchPostStoreProcs { get; set; } = new List<AReportSchPostStoreProc>();

    public virtual ICollection<AReportSchPreStoreProc> AReportSchPreStoreProcs { get; set; } = new List<AReportSchPreStoreProc>();

    public virtual ICollection<AReportTableAlias> AReportTableAliases { get; set; } = new List<AReportTableAlias>();

    public virtual ICollection<AReportType> AReportTypes { get; set; } = new List<AReportType>();

    public virtual ICollection<ASchedulerReportType> ASchedulerReportTypes { get; set; } = new List<ASchedulerReportType>();

    public virtual AReportSmtpServer? SmtpServer { get; set; }

    public virtual ICollection<AReportJoin> AReportJoins { get; set; } = new List<AReportJoin>();
}
