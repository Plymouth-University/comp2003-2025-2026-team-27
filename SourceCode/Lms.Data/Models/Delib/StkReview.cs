using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkReview
{
    public int? SrId { get; set; }

    public string? SrBorBarNo { get; set; }

    public int? SrItemRating { get; set; }

    public DateTime? SrReviewDate { get; set; }

    public string? SrReviewApproved { get; set; }

    public int? SrReviewRating { get; set; }

    public string? SrReview { get; set; }

    public int? SrCatNo { get; set; }
}
