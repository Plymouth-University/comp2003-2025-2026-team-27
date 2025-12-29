using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyQuestion
{
    public int QuestionId { get; set; }

    public int SurveyId { get; set; }

    public string? QuestionText { get; set; }

    public int? QuestionType { get; set; }

    public string? QuestionNote { get; set; }

    public string? Note { get; set; }

    public int? Weighting { get; set; }

    public int? Benchmark { get; set; }
}
