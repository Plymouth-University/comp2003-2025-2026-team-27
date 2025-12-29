using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsSystemMessageArabic
{
    public string MessageId { get; set; } = null!;

    public int Lcid { get; set; }

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public bool Error { get; set; }

    public bool ConfirmationFlag { get; set; }

    public string? ModuleId { get; set; }

    public bool? CacheFlag { get; set; }
}
