using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RotaScheduleItem
{
    public int SiId { get; set; }

    public string RsLibGroup { get; set; } = null!;

    public int ShId { get; set; }

    public DateOnly RsDate { get; set; }

    public TimeOnly? RsTimeFrom { get; set; }

    public TimeOnly? RsTimeTo { get; set; }

    public string? RsComments { get; set; }

    public virtual RotaScheduleHeader RotaScheduleHeader { get; set; } = null!;
}
