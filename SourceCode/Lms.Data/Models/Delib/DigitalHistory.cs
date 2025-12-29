using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class DigitalHistory
{
    public int DhId { get; set; }

    public int? DhBorNo { get; set; }

    public int? DhStkUniqueNo { get; set; }

    public string? DhDwType { get; set; }

    public DateTime? DhDate { get; set; }
}
