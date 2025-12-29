using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class RotaScheduleHeader
{
    public int ShId { get; set; }

    public string ShLibGroup { get; set; } = null!;

    public string ShName { get; set; } = null!;

    public string? ShDescr { get; set; }

    public DateOnly? ShStartDate { get; set; }

    public DateOnly? ShEndDate { get; set; }

    public int SgId { get; set; }

    public bool ShDeleted { get; set; }

    public virtual ICollection<RotaScheduleItem> RotaScheduleItems { get; set; } = new List<RotaScheduleItem>();

    public virtual RotaSchoolGroup RotaSchoolGroup { get; set; } = null!;

    public virtual ICollection<RotaVehicleSchedule> RotaVehicleSchedules { get; set; } = new List<RotaVehicleSchedule>();
}
