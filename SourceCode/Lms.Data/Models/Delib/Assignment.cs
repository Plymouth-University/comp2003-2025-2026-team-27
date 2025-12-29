using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Assignment
{
    public int AssignmentId { get; set; }

    public int? CatNo { get; set; }

    public int? BorNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? DateUpdated { get; set; }
}
