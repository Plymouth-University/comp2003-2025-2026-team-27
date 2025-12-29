using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorSurveyOld
{
    public int SurveyId { get; set; }

    public int BorNo { get; set; }

    public DateTime DateTaken { get; set; }

    public string? Comment { get; set; }

    public bool Approve { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int AnonymousId { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public bool? Showdetails { get; set; }

    public virtual ICollection<BorQuestionCommentOld> BorQuestionCommentOlds { get; set; } = new List<BorQuestionCommentOld>();
}
