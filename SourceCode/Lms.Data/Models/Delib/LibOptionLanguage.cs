using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class LibOptionLanguage
{
    public long LanguageId { get; set; }

    public string Description { get; set; } = null!;

    public string? OptionType { get; set; }

    public string? LoCode { get; set; }
}
