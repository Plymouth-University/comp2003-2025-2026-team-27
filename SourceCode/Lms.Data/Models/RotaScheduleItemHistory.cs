using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class RotaScheduleItemHistory
{
    public int? SiId { get; set; }

    public string? RsLibGroup { get; set; }

    public int? ShId { get; set; }

    public DateOnly? RsDate { get; set; }

    public TimeOnly? RsTimeFrom { get; set; }

    public TimeOnly? RsTimeTo { get; set; }

    public string? RsComments { get; set; }

    public DateTime? DelDate { get; set; }

    public string? DelUser { get; set; }
}
