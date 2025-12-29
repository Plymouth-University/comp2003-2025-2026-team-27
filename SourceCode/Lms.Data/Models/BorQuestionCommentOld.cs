using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorQuestionCommentOld
{
    public int BorNo { get; set; }

    public int SurveyId { get; set; }

    public int QuestionId { get; set; }

    public int AnonymousId { get; set; }

    public string? Comment { get; set; }

    public bool? Approve { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public virtual BorSurveyOld BorSurveyOld { get; set; } = null!;

    public virtual SurveysQuestion SurveysQuestion { get; set; } = null!;
}
