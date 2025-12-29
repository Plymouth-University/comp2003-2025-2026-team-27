using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class DynamicWebpagesTranslation
{
    public int Id { get; set; }

    public string? WebContentTrans { get; set; }

    public int? Lcid { get; set; }

    public string? Description { get; set; }
}
