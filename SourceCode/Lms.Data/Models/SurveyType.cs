using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveyType
{
    public int TypeId { get; set; }

    public string Description { get; set; } = null!;

    public bool? BorMembershipSurvey { get; set; }

    public bool? SmileyFaceSurvey { get; set; }

    public bool? ScoringSurvey { get; set; }

    public virtual ICollection<SurveyTypesTranslation> SurveyTypesTranslations { get; set; } = new List<SurveyTypesTranslation>();
}
