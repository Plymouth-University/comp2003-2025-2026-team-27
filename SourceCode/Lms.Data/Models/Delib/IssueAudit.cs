using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class IssueAudit
{
    public DateTime? IssueDate { get; set; }

    public string? IssueOper { get; set; }

    public string? IssueLocation { get; set; }

    public string? IssueItem { get; set; }

    public string? IssueBorrower { get; set; }

    public string? IssueMessages { get; set; }
}
