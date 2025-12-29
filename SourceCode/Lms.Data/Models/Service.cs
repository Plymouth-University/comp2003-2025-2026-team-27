using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Service
{
    public int SurveyId { get; set; }

    public int DisplayOrder { get; set; }

    public int ServiceNameId { get; set; }

    public int ServicesId { get; set; }

    public virtual ServiceName ServiceName { get; set; } = null!;
}
