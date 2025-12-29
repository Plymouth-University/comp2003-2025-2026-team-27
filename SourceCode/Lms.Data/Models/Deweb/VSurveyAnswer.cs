using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyAnswer
{
    public int AnswerId { get; set; }

    public int SurveyId { get; set; }

    public int QuestionId { get; set; }

    public string? Other { get; set; }

    public string? AnswerText { get; set; }

    public int? AnswerValue { get; set; }

    public int? NextSurveyId { get; set; }

    public int? NextQuestionId { get; set; }

    public string? AnswerText2 { get; set; }
}
