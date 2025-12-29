using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class Contact
{
    public int ClientNumber { get; set; }

    public int SiteNumber { get; set; }

    public string ContactName { get; set; } = null!;

    public string? ContactDept { get; set; }

    public DateTime? ContactBirthday { get; set; }

    public string? ContactTelNo { get; set; }

    public string? ContactFaxNo { get; set; }

    public byte[]? ContactComment { get; set; }

    public DateTime? InactiveDate { get; set; }

    public decimal? CommEstThisYr { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateOp { get; set; } = null!;

    public DateTime LastUpDate { get; set; }

    public string LastUpOp { get; set; } = null!;

    public decimal? CommEstToDate { get; set; }

    public decimal? CommEarnThisYr { get; set; }

    public decimal? CommEarnToDate { get; set; }

    public decimal? CommPaidThisYr { get; set; }

    public decimal? CommPaidToDate { get; set; }

    public DateTime? BrochureSent { get; set; }

    public DateTime? LoyalEnrDate { get; set; }

    public string? ContactMobileNo { get; set; }

    public short? ContBillbackAc { get; set; }

    public DateTime? ContactChase { get; set; }

    public string? Source { get; set; }

    public string? EmailAddr { get; set; }

    public decimal? VouchValThisYr { get; set; }

    public decimal? VouchValToDate { get; set; }

    public short? ContBillbackEv { get; set; }

    public DateTime? TimeWasterDate { get; set; }

    public string? JobTitle { get; set; }

    public string? LoyalVouchType { get; set; }

    public string? LoyalExtId { get; set; }

    public short? ContBillbackCb { get; set; }

    public string? ContBillbackBi { get; set; }

    public string? ContDefaultBi { get; set; }

    public string? ContactNameNew { get; set; }

    public short? XmasCardList { get; set; }

    public short? ExclFromMailshot { get; set; }

    public string? ContAccomAlert { get; set; }

    public string? ContEventAlert { get; set; }

    public string? ContEvntBbBi { get; set; }

    public string? ContEventBi { get; set; }

    public string? ContChaseReason { get; set; }

    public string? CreditCardGuar { get; set; }

    public DateTime? CcExpGuar { get; set; }

    public short? CostCentreReqacc { get; set; }

    public short? CostCentreReqev { get; set; }

    public virtual Site Site { get; set; } = null!;
}
