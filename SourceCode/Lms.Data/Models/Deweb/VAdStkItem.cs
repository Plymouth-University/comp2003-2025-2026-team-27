using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAdStkItem
{
    public string? AuditType { get; set; }

    public int? StkCatRef { get; set; }

    public string? StkItemNo { get; set; }

    public DateTime? StkDateRecd { get; set; }

    public DateTime? StkDateDue { get; set; }

    public string? StkLine2 { get; set; }

    public string? StkLine1 { get; set; }

    public string? StkLine3 { get; set; }

    public string? StkLine4 { get; set; }

    public string? StkLine5 { get; set; }

    public string? StkLine6 { get; set; }

    public decimal? StkCost { get; set; }

    public string? StkEdition { get; set; }

    public string? StkDescription { get; set; }

    public string? StkVolume { get; set; }

    public DateTime? StkLastTake { get; set; }

    public int? StkTimesBorrowed { get; set; }

    public int? StkTimesReserved { get; set; }

    public int? StkTimesRenewed { get; set; }

    public int? StkIsReserved { get; set; }

    public int? UniqueItemNo { get; set; }

    public string? StkOper { get; set; }

    public DateTime? StkDatetime { get; set; }

    public DateTime? StkLastactive { get; set; }

    public DateTime? StkDateAcc { get; set; }

    public string? StkForLoan { get; set; }

    public int? StkLastResno { get; set; }

    public string? StkKey1 { get; set; }

    public string? StkKey2 { get; set; }

    public string? StkKey3 { get; set; }

    public string? StkKey4 { get; set; }

    public string? StkKey5 { get; set; }

    public string? StkKey6 { get; set; }

    public string? StkStatsCode { get; set; }

    public string? StkLocTemp { get; set; }

    public string? StkLocPerm { get; set; }

    public string? StkStockTake { get; set; }

    public string? StkIsOnLoan { get; set; }

    public string? StkIsOnOrder { get; set; }

    public string? StkForm { get; set; }

    public string? StkLocFloor { get; set; }

    public decimal? StkOrigCost { get; set; }

    public string? StkLibGroup { get; set; }

    public string? StkConvertValue { get; set; }
}
