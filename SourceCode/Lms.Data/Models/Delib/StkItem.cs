using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkItem
{
    public int? StkCatRef { get; set; }

    public string StkItemNo { get; set; } = null!;

    public string? StkBorBarNo { get; set; }

    public DateTime? StkIssDue { get; set; }

    public string? StkLibGroup { get; set; }

    public DateTime? StkDateRecd { get; set; }

    public string? StkLine2 { get; set; }

    public string? StkLine1 { get; set; }

    public string? StkLine3 { get; set; }

    public string? StkLine4 { get; set; }

    public string? StkLine5 { get; set; }

    public string? StkLine6 { get; set; }

    public decimal? StkCost { get; set; }

    public string? StkEdition { get; set; }

    public string? StkVolume { get; set; }

    public string? StkIssLoc { get; set; }

    public DateTime? StkDateDue { get; set; }

    public int? StkTimesBorrowed { get; set; }

    public int? StkTimesReserved { get; set; }

    public int? StkTimesRenewed { get; set; }

    public int? StkIssRenewed { get; set; }

    public DateTime? StkIssDate { get; set; }

    public int? StkIsReserved { get; set; }

    public string? StkIssueType { get; set; }

    public string? StkConvertValue { get; set; }

    public DateTime? StkLastTake { get; set; }

    public int? UniqueItemNo { get; set; }

    public string? StkOper { get; set; }

    public DateTime? StkDatetime { get; set; }

    public DateTime? StkLastactive { get; set; }

    public DateTime? StkLastDep { get; set; }

    public string? StkForLoan { get; set; }

    public int? StkLastResno { get; set; }

    public string? StkKey1 { get; set; }

    public string? StkKey2 { get; set; }

    public string? StkKey3 { get; set; }

    public string? StkKey4 { get; set; }

    public string? StkKey5 { get; set; }

    public string? StkKey6 { get; set; }

    public string? StkDescription { get; set; }

    public string? StkStatsCode { get; set; }

    public string? StkOpacShow { get; set; }

    public string? StkOperAlert { get; set; }

    public string? StkLocFloor { get; set; }

    public string? StkProcess { get; set; }

    public DateTime? StkProcessDate { get; set; }

    public string? StkLocTemp { get; set; }

    public string? StkLocPerm { get; set; }

    public string? StkStockTake { get; set; }

    public string? StkIsOnLoan { get; set; }

    public string? StkIsOnOrder { get; set; }

    public string? StkForm { get; set; }

    public string? StkBorName { get; set; }

    public string? StkItemOrigin { get; set; }

    public string? StkLoanType { get; set; }

    public int? StkTimesBorpr { get; set; }

    public int? StkTimesRenpr { get; set; }

    public int? StkTimesResvpr { get; set; }

    public DateTime? StkDateAcc { get; set; }

    public string? StkIllRenew { get; set; }

    public string? StkIllSupp { get; set; }

    public int? StkRelatedNo { get; set; }

    public string? StkItemType { get; set; }

    public string? StkCallSet { get; set; }

    public decimal? StkOrigCost { get; set; }

    public DateTime? StkIllDue { get; set; }

    public int? StkAvgRating { get; set; }

    public int? StkRotationPlanId { get; set; }

    public DateTime? StkRotationDate { get; set; }

    public string? StkRotationLoCode { get; set; }

    public int? StkRotationSeqNo { get; set; }

    public string? StkRotationTransit { get; set; }

    public int? StkIssueAddrNo { get; set; }

    public DateTime? StkRecallDate { get; set; }

    public string? StkOtherRef { get; set; }

    public int? StkLocFloorId { get; set; }

    public string? StkClass { get; set; }

    public string? CnPrefix { get; set; }

    public int? CnSuffix { get; set; }

    public int? RetId { get; set; }

    public DateTime? DestructionDate { get; set; }

    public int? TeamId { get; set; }
}
