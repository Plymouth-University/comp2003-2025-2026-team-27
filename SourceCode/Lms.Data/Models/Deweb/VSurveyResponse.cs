using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSurveyResponse
{
    public int UserId { get; set; }

    public int SurveyId { get; set; }

    public int SerialNum { get; set; }

    public int QuestionId { get; set; }

    public int AnswerId { get; set; }

    public string? Other { get; set; }

    public string? Approve { get; set; }

    public int AnonymousId { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovalDate { get; set; }
}
