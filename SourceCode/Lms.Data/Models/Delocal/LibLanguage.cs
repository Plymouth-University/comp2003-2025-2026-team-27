using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibLanguage
{
    public int LanguageId { get; set; }

    public string? Description { get; set; }

    public int Lcid { get; set; }

    public bool? Active { get; set; }
}
