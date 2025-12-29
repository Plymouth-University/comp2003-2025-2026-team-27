using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RepOrder
{
    public int? RoOrderNo { get; set; }

    public int? RoOrder { get; set; }

    public int? RoColumn { get; set; }

    public string? RoSortOrder { get; set; }

    public string? RoColName { get; set; }
}
