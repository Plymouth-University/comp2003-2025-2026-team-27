using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class QueryStatus
{
    public int Id { get; set; }

    public string? Activity { get; set; }

    public string? MethodName { get; set; }

    public int? TagNo { get; set; }

    public string? QueryStatus1 { get; set; }

    public int? RowsUpdated { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? LlCode { get; set; }

    public string? Message { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? Operator { get; set; }

    public int? DeleteFlag { get; set; }

    public int? CurrentItem { get; set; }

    public int? LastItem { get; set; }

    public int? Iteration { get; set; }

    public int? CurrentItem2 { get; set; }

    public int? LastItem2 { get; set; }
}
