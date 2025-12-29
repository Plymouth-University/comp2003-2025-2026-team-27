using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveysQuestion
{
    public int QuestionId { get; set; }

    public int SurveyId { get; set; }

    public string? QuestionText { get; set; }

    public int? QuestionType { get; set; }

    public bool QuestionNote { get; set; }

    public string? Note { get; set; }

    public int? Weighting { get; set; }

    public int? Benchmark { get; set; }

    public string? Categoryid { get; set; }

    public virtual ICollection<BorAnswer> BorAnswers { get; set; } = new List<BorAnswer>();

    public virtual ICollection<BorQuestionCommentOld> BorQuestionCommentOlds { get; set; } = new List<BorQuestionCommentOld>();

    public virtual ICollection<BorQuestionComment> BorQuestionComments { get; set; } = new List<BorQuestionComment>();

    public virtual Survey Survey { get; set; } = null!;

    public virtual ICollection<SurveysAnswer> SurveysAnswers { get; set; } = new List<SurveysAnswer>();
}
