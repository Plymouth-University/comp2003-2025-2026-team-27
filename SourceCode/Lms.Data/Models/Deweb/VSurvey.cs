using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurvey
{
    public int SurveyId { get; set; }

    public string? SurveyDescription { get; set; }

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

    public string? AllowComment { get; set; }

    public string? Comment { get; set; }

    public string? Allowhidedetails { get; set; }

    public string? Completeallquestions { get; set; }

    public string? Restricted { get; set; }

    public int? Position { get; set; }

    public string? Inlinedisplay { get; set; }

    public string? MasterFlag { get; set; }

    public int? MasterId { get; set; }
}
