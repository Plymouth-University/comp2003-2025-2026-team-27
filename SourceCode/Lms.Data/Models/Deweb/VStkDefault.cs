using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStkDefault
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

    public string? StkitemStkForm { get; set; }

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

    public int? BorNo { get; set; }

    public string? BorBarNo { get; set; }

    public string? BorSurname { get; set; }

    public string? BorGiven { get; set; }

    public string? BorClass { get; set; }

    public string? BorGroup { get; set; }

    public DateTime? BorDob { get; set; }

    public DateTime? BorRegdate { get; set; }

    public string? BorTitle { get; set; }

    public string? BorEmail { get; set; }

    public string? BorUseEmail { get; set; }

    public DateTime? BorStartMship { get; set; }

    public decimal? BorOwing { get; set; }

    public int? BorAddr1No { get; set; }

    public int? BorAddr2No { get; set; }

    public int? BorAddr3No { get; set; }

    public string? BorAddr1Txt { get; set; }

    public string? BorAddr2Txt { get; set; }

    public string? BorAddr3Txt { get; set; }

    public DateTime? BorLastactive { get; set; }

    public DateTime? BorDatetime { get; set; }

    public string? BorStartLocation { get; set; }

    public string? BorSoundex { get; set; }

    public int? BorNoLoans { get; set; }

    public int? BorNoReserves { get; set; }

    public int? BorNoRenews { get; set; }

    public int? BorNoOpacs { get; set; }

    public string? BorPin { get; set; }

    public int? BorNoVisits { get; set; }

    public string? BorRef1 { get; set; }

    public string? BorRef2 { get; set; }

    public string? BorSurnameKey { get; set; }

    public string? BorInit { get; set; }

    public string? BorSex { get; set; }

    public string? BorType { get; set; }

    public string? BorStatus { get; set; }

    public string? BorLocation { get; set; }

    public string? BorOper { get; set; }

    public string? BorMobileTel { get; set; }

    public string? BorMobUsfn { get; set; }

    public string? BorLibGroup { get; set; }

    public int? BorSecurity { get; set; }

    public string? BorPicFilename { get; set; }

    public string? BorPicType { get; set; }

    public byte[]? BorPicData { get; set; }

    public string? BorApproved { get; set; }

    public string? StkCodeDesc { get; set; }

    public string? StkGroup { get; set; }

    public string? StkCode { get; set; }

    public string? StkcodeStkAllowLoan { get; set; }

    public string? StkcodeStkFloating { get; set; }

    public string? StkJournalSearchShowyn { get; set; }

    public string? StkformStkform { get; set; }

    public string? StkFormDesc { get; set; }

    public string? StkformStkAllowLoan { get; set; }

    public string? StkformStkFloating { get; set; }
}
