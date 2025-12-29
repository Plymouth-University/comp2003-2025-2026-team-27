using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AEmailTemplateClient
{
    public int Uniqueid { get; set; }

    public string? TemplateSubject { get; set; }

    public string? TemplateValue { get; set; }

    public int Userid { get; set; }

    public string? DefaultEmail { get; set; }

    public string? DefaultBccEmail { get; set; }
}
