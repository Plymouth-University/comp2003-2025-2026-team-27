using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class SysSsheet
{
    public string? ShtRef { get; set; }

    public int? ShtRefSeq { get; set; }

    public string? ShtStatsCodes { get; set; }

    public string? ShtLocn { get; set; }

    public string? ShtForm { get; set; }

    public string? ShtBorr { get; set; }

    public string? ShtStkCodes { get; set; }

    public string? ShtDays { get; set; }

    public string? ShtHours { get; set; }

    public string? ShtMonths { get; set; }

    public string? ShtYears { get; set; }

    public int? ShtStartCol { get; set; }

    public int? ShtStartRow { get; set; }

    public string? ShtType { get; set; }

    public string? ShtWard { get; set; }

    public string? ShtSuburb { get; set; }

    public string? ShtAreaCd { get; set; }

    public DateTime? ShtDateFrom { get; set; }

    public DateTime? ShtDateTo { get; set; }

    public int? ShtDaysBack { get; set; }

    public string? ShtBorg { get; set; }

    public string? ShtBorc { get; set; }
}
