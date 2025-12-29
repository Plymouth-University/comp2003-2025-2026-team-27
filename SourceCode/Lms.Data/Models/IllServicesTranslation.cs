using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class IllServicesTranslation
{
    public string IllsCode { get; set; } = null!;

    public string IllsIllCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? IllsKeywordDescription { get; set; }

    public virtual IllService IllService { get; set; } = null!;
}
