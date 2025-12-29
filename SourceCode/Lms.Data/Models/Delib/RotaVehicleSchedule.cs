using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RotaVehicleSchedule
{
    public int RvId { get; set; }

    public int ShId { get; set; }

    public string RvsLibGroup { get; set; } = null!;

    public string? RvsComments { get; set; }

    public virtual RotaScheduleHeader RotaScheduleHeader { get; set; } = null!;

    public virtual RotaVehicle RotaVehicle { get; set; } = null!;
}
