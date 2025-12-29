using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VMypc
{
    public string? BorrowerId { get; set; }

    public int? OverDueQuantity { get; set; }

    public int? OverdueDays { get; set; }

    public decimal? Owing { get; set; }
}
