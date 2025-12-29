using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveyTypesTranslation
{
    public int TypeId { get; set; }

    public int Lcid { get; set; }

    public string Description { get; set; } = null!;

    public virtual SurveyType Type { get; set; } = null!;
}
