using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AAnsUser
{
    /// <summary>
    /// ANS USERS TABLE
    /// </summary>
    public int AAnsUser1 { get; set; }

    public string? FullName { get; set; }

    public string? Username { get; set; }

    public string? UserPassword { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LocalId { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime? ValidFrom { get; set; }

    public int? ClientNumber { get; set; }

    public int? SiteNumber { get; set; }

    public string? ContactName { get; set; }

    public string? UserPasswordHash { get; set; }

    public string? Email { get; set; }

    public bool? DeleteFlag { get; set; }

    public bool? EmailFlag { get; set; }

    public string? ResetPwToken { get; set; }

    public string? OperLlCode { get; set; }

    public virtual ICollection<AEvent> AEvents { get; set; } = new List<AEvent>();

    public virtual ICollection<ALoginHistory> ALoginHistories { get; set; } = new List<ALoginHistory>();

    public virtual ICollection<APasswordHistory> APasswordHistories { get; set; } = new List<APasswordHistory>();

    public virtual ICollection<AProfileUser> AProfileUsers { get; set; } = new List<AProfileUser>();

    public virtual ICollection<AClientReport> AClientReports { get; set; } = new List<AClientReport>();

    public virtual ICollection<AScheduler> Schedulers { get; set; } = new List<AScheduler>();
}
