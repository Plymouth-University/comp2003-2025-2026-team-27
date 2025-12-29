using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyStatus
{
    public int StatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusDescription { get; set; }
}
