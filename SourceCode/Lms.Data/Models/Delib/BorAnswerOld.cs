using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorAnswerOld
{
    public int BorNo { get; set; }

    public int SurveyId { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public string? Other { get; set; }

    public bool? Approve { get; set; }

    public int AnonymousId { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public virtual Borrower BorNoNavigation { get; set; } = null!;

    public virtual BorSurveyOld BorSurveyOld { get; set; } = null!;

    public virtual Survey Survey { get; set; } = null!;

    public virtual SurveysAnswer SurveysAnswer { get; set; } = null!;

    public virtual SurveysQuestion SurveysQuestion { get; set; } = null!;
}
