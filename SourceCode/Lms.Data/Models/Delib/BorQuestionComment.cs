using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorQuestionComment
{
    public int BorNo { get; set; }

    public int SurveyId { get; set; }

    public int SerialNum { get; set; }

    public int QuestionId { get; set; }

    public int AnonymousId { get; set; }

    public string? Comment { get; set; }

    public bool? Approve { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public virtual BorSurvey BorSurvey { get; set; } = null!;

    public virtual SurveysQuestion SurveysQuestion { get; set; } = null!;
}
