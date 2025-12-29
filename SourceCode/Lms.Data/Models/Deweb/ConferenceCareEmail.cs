using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class ConferenceCareEmail
{
    public int ClientNumber { get; set; }

    public string ContactName { get; set; } = null!;

    public string? ContactNameNew { get; set; }

    public string? ContactDept { get; set; }

    public int SiteNumber { get; set; }

    public DateOnly? ContactBirthday { get; set; }

    public string? ContactTelNo { get; set; }

    public string? ContactFaxNo { get; set; }

    public DateOnly? InactiveDate { get; set; }

    public string? EmailAddr { get; set; }

    public string? JobTitle { get; set; }

    public int? XmasCardList { get; set; }

    public string? ContactGiven { get; set; }
}
