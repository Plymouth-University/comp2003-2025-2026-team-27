using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StkItemDiary
{
    public int StkItemDiaryid { get; set; }

    public int UniqueItemNo { get; set; }

    public string? SlotDescription { get; set; }

    public DateTime? SlotStartDate { get; set; }

    public DateTime? SlotEndDate { get; set; }

    public string? Status { get; set; }

    public DateTime? Date { get; set; }

    public int? WeekId { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }
}
