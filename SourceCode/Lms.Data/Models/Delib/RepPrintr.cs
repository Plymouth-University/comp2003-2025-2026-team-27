using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RepPrintr
{
    public string? RepDescription { get; set; }

    public string? RepFilename { get; set; }

    public int? RepStatsCode { get; set; }

    public string? RepReportVars { get; set; }

    public int? RepSubStats { get; set; }

    public int? RepPageFrom { get; set; }

    public int? RepPageTo { get; set; }

    public int? RepCopies { get; set; }

    public string? RepDraft { get; set; }

    public DateTime? RepDateToPrint { get; set; }

    public DateTime? RepDatePrinted { get; set; }

    public string? RepProgress { get; set; }

    public string? RepRepeat { get; set; }

    public DateTime? RepDatetime { get; set; }

    public string? RepOper { get; set; }

    public int? RepPrintNo { get; set; }

    public string? RepFileDesc { get; set; }

    public string? RepScreen { get; set; }

    public string? RepPrintfile { get; set; }

    public string? RepCreateHistory { get; set; }

    public string? RepUpdate { get; set; }

    public int? RepType { get; set; }

    public string? RepLlCode { get; set; }

    public int? RepNumber { get; set; }

    public string? RepOverwriteFile { get; set; }

    public string? RepPrinter { get; set; }
}
