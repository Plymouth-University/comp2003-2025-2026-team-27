using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAdBorrower
{
    public string? AuditType { get; set; }

    public int? BorNo { get; set; }

    public string? BorBarNo { get; set; }

    public string? BorSurname { get; set; }

    public string? BorGiven { get; set; }

    public string? BorClass { get; set; }

    public string? BorGroup { get; set; }

    public DateTime? BorDob { get; set; }

    public DateTime? BorRegdate { get; set; }

    public string? BorTitle { get; set; }

    public decimal? BorOwing { get; set; }

    public int? BorAddr1No { get; set; }

    public int? BorAddr2No { get; set; }

    public int? BorAddr3No { get; set; }

    public string? BorAddr1Txt { get; set; }

    public string? BorAddr2Txt { get; set; }

    public string? BorAddr3Txt { get; set; }

    public DateTime? BorLastactive { get; set; }

    public DateTime? BorDatetime { get; set; }

    public string? BorSoundex { get; set; }

    public int? BorNoLoans { get; set; }

    public int? BorNoReserves { get; set; }

    public int? BorNoRenews { get; set; }

    public int? BorNoOpacs { get; set; }

    public string? BorPin { get; set; }

    public int? BorNoVisits { get; set; }

    public string? BorRef1 { get; set; }

    public string? BorRef2 { get; set; }

    public string? BorInit { get; set; }

    public string? BorSex { get; set; }

    public string? BorType { get; set; }

    public string? BorStatus { get; set; }

    public string? BorLocation { get; set; }

    public string? BorOper { get; set; }

    public string? BorSurnameKey { get; set; }

    public string? BorEmail { get; set; }

    public string? BorUseEmail { get; set; }

    public DateTime? BorStartMship { get; set; }

    public string? BorStartLocation { get; set; }

    public string? BorMobileTel { get; set; }

    public string? BorMobUsfn { get; set; }

    public string? BorLibGroup { get; set; }

    public int? BorSecurity { get; set; }

    public DateTime? AuditDate { get; set; }

    public string? BorRef3 { get; set; }

    public string? Salutation { get; set; }

    public string? BorApproved { get; set; }

    public int? BorNoSee { get; set; }

    public string? BorRelType { get; set; }

    public string? BorEmailPin { get; set; }

    public string? BorEmailPinReset { get; set; }

    public string? BorReqPinChange { get; set; }

    public string? BorRejectedEmail { get; set; }

    public string? BorRamdomKey { get; set; }

    public decimal? BorPotentialCharge { get; set; }

    public string? ReceiveInfoByPost { get; set; }

    public string? ContactTel { get; set; }

    public string? ReceiveEmails { get; set; }

    public bool? Primarycontact { get; set; }

    public int? PreBorNoSee { get; set; }

    public int? ReadingChallenge { get; set; }

    public bool? Isshowinitial { get; set; }

    public string? Gdpr { get; set; }

    public byte[]? Encryptedid { get; set; }

    public int? ParentBorNoSee { get; set; }

    public string? BorPhoneTel { get; set; }

    public string? BorPhoUsfn { get; set; }

    public string? BorEmail2 { get; set; }

    public string? BorUseEmail2 { get; set; }
}
