using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkLoanTypesTranslation
{
    public string StlLoanType { get; set; } = null!;

    public int Lcid { get; set; }

    public string? StlLoanDesc { get; set; }
}
