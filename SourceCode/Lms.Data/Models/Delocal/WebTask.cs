using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class WebTask
{
    public int? TaskNo { get; set; }

    public int? TaskSerial { get; set; }

    public string? TaskStatus { get; set; }

    public string? TaskType { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? TaskStartDate { get; set; }

    public DateTime? TaskFinishDate { get; set; }

    public int? TaskSavedFileNo { get; set; }

    public int? TaskNextId { get; set; }

    public int? TaskMaxItems { get; set; }

    public int? TaskItemsProcessed { get; set; }

    public string? TaskParams { get; set; }
}
