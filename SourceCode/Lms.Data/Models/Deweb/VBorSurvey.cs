using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBorSurvey
{
    public int SurveyId { get; set; }

    public int BorNo { get; set; }

    public int SerialNum { get; set; }

    public DateTime DateTaken { get; set; }

    public string? Comment { get; set; }

    public string? Approve { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int AnonymousId { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? Showdetails { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? DateTakenBy { get; set; }
}
