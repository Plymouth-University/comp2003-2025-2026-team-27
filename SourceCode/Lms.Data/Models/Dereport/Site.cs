using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class Site
{
    public int ClientNumber { get; set; }

    public int SiteNumber { get; set; }

    public string SiteName { get; set; } = null!;

    public string? SiteAddrL2 { get; set; }

    public string? SiteAddrL3 { get; set; }

    public string? SiteTown { get; set; }

    public string? SiteCounty { get; set; }

    public string? SitePostcode { get; set; }

    public string? SiteTelNo { get; set; }

    public string? SiteFaxNo { get; set; }

    public string AccountMan { get; set; } = null!;

    public short? TrainServSite { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateOp { get; set; } = null!;

    public DateTime LastUpDate { get; set; }

    public string LastUpOp { get; set; } = null!;

    public decimal CommEstThisYr { get; set; }

    public decimal CommEstToDate { get; set; }

    public decimal CommEarnThisYr { get; set; }

    public decimal CommEarnToDate { get; set; }

    public decimal CommPaidThisYr { get; set; }

    public decimal CommPaidToDate { get; set; }

    public byte[]? SiteComment { get; set; }

    public DateTime? LoyalEnrDate { get; set; }

    public string? LoyalContName { get; set; }

    public decimal? VouchValThisYr { get; set; }

    public decimal? VouchValToDate { get; set; }

    public string? SiteCountry { get; set; }

    public short? SiteBillbackAc { get; set; }

    public short? SiteBillbackEv { get; set; }

    public string? ResAccMan { get; set; }

    public virtual Client ClientNumberNavigation { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
