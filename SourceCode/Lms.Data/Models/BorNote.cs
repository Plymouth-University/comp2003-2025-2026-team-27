using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorNote
{
    public int BorNo { get; set; }

    public string? Note { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
