using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RotaVehicle
{
    public int RvId { get; set; }

    public string RvLibGroup { get; set; } = null!;

    public string RvName { get; set; } = null!;

    public string? RvDescr { get; set; }

    public bool RvDeleted { get; set; }

    public decimal? RvWeight { get; set; }

    public virtual ICollection<RotaVehicleSchedule> RotaVehicleSchedules { get; set; } = new List<RotaVehicleSchedule>();
}
