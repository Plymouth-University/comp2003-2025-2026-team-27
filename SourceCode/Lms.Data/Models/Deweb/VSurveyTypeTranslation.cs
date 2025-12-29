using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyTypeTranslation
{
    public int TypeId { get; set; }

    public int Lcid { get; set; }

    public string Description { get; set; } = null!;
}
