using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorSurvey
{
    public int SurveyId { get; set; }

    public int BorNo { get; set; }

    public int SerialNum { get; set; }

    public DateTime DateTaken { get; set; }

    public string? Comment { get; set; }

    public bool Approve { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int AnonymousId { get; set; }

    public string? ApproveBy { get; set; }

    public DateTime? ApproveDate { get; set; }

    public bool? Showdetails { get; set; }

    public string? DateTakenBy { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? BorEmail { get; set; }

    public virtual ICollection<BorAnswer> BorAnswers { get; set; } = new List<BorAnswer>();

    public virtual Borrower BorNoNavigation { get; set; } = null!;

    public virtual ICollection<BorQuestionComment> BorQuestionComments { get; set; } = new List<BorQuestionComment>();

    public virtual Survey Survey { get; set; } = null!;
}
