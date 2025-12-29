using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyType
{
    public int TypeId { get; set; }

    public string Description { get; set; } = null!;

    public string? BorMembershipSurvey { get; set; }
}
