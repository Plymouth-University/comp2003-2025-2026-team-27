using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorPrePw
{
    public int Id { get; set; }

    public int? BorNo { get; set; }

    public string? BorBarNo { get; set; }

    public DateTime? DateRenewed { get; set; }

    public string? BorPin { get; set; }

    public string? ResetBy { get; set; }
}
