using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AScheduler
{
    public int SchedulerId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? NextExecuteOn { get; set; }

    public DateTime? LastExecutedOn { get; set; }

    public bool? Enable { get; set; }

    public short DeleteFlag { get; set; }

    public DateTime? NextRecurrenceOn { get; set; }

    public DateTime? LastTriggeredOn { get; set; }

    public virtual ICollection<AReportEmail> AReportEmails { get; set; } = new List<AReportEmail>();

    public virtual ICollection<ASchedulerLog> ASchedulerLogs { get; set; } = new List<ASchedulerLog>();

    public virtual ASchedulerRecurrence? ASchedulerRecurrence { get; set; }

    public virtual ICollection<ASchedulerReportBatch> ASchedulerReportBatches { get; set; } = new List<ASchedulerReportBatch>();

    public virtual ICollection<ASchedulerReport> ASchedulerReports { get; set; } = new List<ASchedulerReport>();

    public virtual ICollection<AAnsUser> AAnsUsers { get; set; } = new List<AAnsUser>();
}
