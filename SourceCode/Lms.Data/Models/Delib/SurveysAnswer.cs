using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class SurveysAnswer
{
    public int AnswerId { get; set; }

    public int SurveyId { get; set; }

    public int QuestionId { get; set; }

    public bool Other { get; set; }

    public string? AnswerText { get; set; }

    public int? AnswerValue { get; set; }

    public int? NextSurveyId { get; set; }

    public int? NextQuestionId { get; set; }

    public string? AnswerText2 { get; set; }

    public int? SmileyFaceId { get; set; }

    public virtual ICollection<BorAnswer> BorAnswers { get; set; } = new List<BorAnswer>();

    public virtual SurveysQuestion SurveysQuestion { get; set; } = null!;
}
