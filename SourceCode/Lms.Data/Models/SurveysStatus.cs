using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveysStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public virtual ICollection<Survey> Surveys { get; set; } = new List<Survey>();
}
