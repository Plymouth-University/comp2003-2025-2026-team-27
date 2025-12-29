using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveyRestriction
{
    public int BorNo { get; set; }

    public int SurveyId { get; set; }

    public string? Sentyn { get; set; }

    public DateTime? DatetimeSent { get; set; }

    public virtual Borrower BorNoNavigation { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;
}
