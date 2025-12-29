using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AdBorAddr
{
    public int BaAddrNo { get; set; }

    public string? BaTelephone { get; set; }

    public string? BaAddr1 { get; set; }

    public string? BaAddr2 { get; set; }

    public string? BaPcode { get; set; }

    public string? BaAreaCd { get; set; }

    public string? BaSuburbCd { get; set; }

    public string? BaWardCd { get; set; }

    public DateTime? BaDatetime { get; set; }

    public string? BaPopup { get; set; }

    public string? BaAddr3 { get; set; }

    public string? BaOper { get; set; }

    public string? BaAddr4 { get; set; }

    public string? BaDpbarcode { get; set; }

    public int? BaBorNo { get; set; }

    public int? BaAddressTypeId { get; set; }

    public DateTime? BaValidFrom { get; set; }

    public DateTime? BaValidTo { get; set; }

    public int? BaCountryid { get; set; }

    public bool? BaMain { get; set; }

    public bool? BaMailing { get; set; }

    public string? BaSalutation { get; set; }

    public int? VerifyAddress { get; set; }

    public string? VerifiedBy { get; set; }

    public string? BaAddr5 { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string? AuditType { get; set; }
}
