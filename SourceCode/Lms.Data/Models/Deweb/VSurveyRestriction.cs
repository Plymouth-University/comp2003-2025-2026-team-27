using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyRestriction
{
    public int BorNo { get; set; }

    public int SurveyId { get; set; }

    public string? Sentyn { get; set; }

    public DateTime? DatetimeSent { get; set; }
}
