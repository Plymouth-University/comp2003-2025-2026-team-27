using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class RotaVehicleScheduleHistory
{
    public int RvId { get; set; }

    public int ShId { get; set; }

    public string? RvsLibGroup { get; set; }

    public string? RvsComments { get; set; }

    public DateTime? DelDate { get; set; }

    public string? DelUser { get; set; }
}
