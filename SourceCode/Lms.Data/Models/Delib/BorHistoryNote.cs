using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorHistoryNote
{
    public int HistoryId { get; set; }

    public int BorNo { get; set; }

    public int? BhnTypeId { get; set; }

    public int? BhnCategoryId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public int? BhnResultId { get; set; }

    public string? ResultCode { get; set; }

    public string? ShortDesc { get; set; }

    public string? Notes { get; set; }
}
