using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReport
{
    public int AReport { get; set; }

    public string ReportGrpName { get; set; } = null!;

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

    public string? Dbname { get; set; }

    public int? ClientBaseReport { get; set; }

    public string? DistinctFlag { get; set; }

    public bool? FreeHandSqlFlag { get; set; }

    public int? PositionInGroup { get; set; }

    public bool? ReportTemplateFlag { get; set; }

    public string? DefaultEmailSubject { get; set; }

    public bool? EmailFlag { get; set; }

    public bool? EmailReadReceipt { get; set; }

    public bool? EmailDeliveryReceipt { get; set; }

    public string? SmtpName { get; set; }

    public string? SmtpDescription { get; set; }

    public string? SmtpHost { get; set; }

    public int? SmtpPort { get; set; }

    public bool? SmtpAuth { get; set; }

    public string? SmtpUser { get; set; }

    public string? SmtpPwd { get; set; }

    public bool? SystemReport { get; set; }

    public bool? TableViewFlag { get; set; }

    public string? RepQrpTitle1 { get; set; }

    public string? RepQrpTitle2 { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public int? ImportId { get; set; }
}
