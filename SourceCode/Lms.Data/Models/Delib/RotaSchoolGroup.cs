using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RotaSchoolGroup
{
    public int SgId { get; set; }

    public string SgLibGroup { get; set; } = null!;

    public string SgName { get; set; } = null!;

    public string? SgDescr { get; set; }

    public bool SgDeleted { get; set; }

    public virtual ICollection<RotaScheduleHeader> RotaScheduleHeaders { get; set; } = new List<RotaScheduleHeader>();

    public virtual ICollection<RotaSchool> RotaSchools { get; set; } = new List<RotaSchool>();
}
