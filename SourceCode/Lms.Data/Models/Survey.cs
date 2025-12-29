using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Survey
{
    public int SurveyId { get; set; }

    public string? Description { get; set; }

    public string SurveyTitle { get; set; } = null!;

    public int StatusId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Oper { get; set; } = null!;

    public string? ConclusionUrl { get; set; }

    public string? ProposalUrl { get; set; }

    public string? SummaryUrl { get; set; }

    public int? Type { get; set; }

    public string Libgroup { get; set; } = null!;

    public string Libloc { get; set; } = null!;

    public string? OperUpdated { get; set; }

    public DateTime? LastUpdated { get; set; }

    public bool? AllowComment { get; set; }

    public string? Comment { get; set; }

    public bool? Allowhidedetails { get; set; }

    public bool? Completeallquestions { get; set; }

    public bool? Restricted { get; set; }

    public int? Position { get; set; }

    public bool? Inlinedisplay { get; set; }

    public bool? MasterFlag { get; set; }

    public int? MasterId { get; set; }

    public string? DescHtml { get; set; }

    public bool? Showprogressbar { get; set; }

    public virtual ICollection<BorAnswer> BorAnswers { get; set; } = new List<BorAnswer>();

    public virtual ICollection<BorSurvey> BorSurveys { get; set; } = new List<BorSurvey>();

    public virtual SurveysStatus Status { get; set; } = null!;

    public virtual ICollection<SurveyRestriction> SurveyRestrictions { get; set; } = new List<SurveyRestriction>();

    public virtual ICollection<SurveysQuestion> SurveysQuestions { get; set; } = new List<SurveysQuestion>();
}
