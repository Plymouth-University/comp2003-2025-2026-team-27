using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RetentionCode
{
    public int RetId { get; set; }

    public string? RetCode { get; set; }

    public string? RetPrefix { get; set; }

    public int? LenDays { get; set; }

    public int? LenMonths { get; set; }

    public int? LenYears { get; set; }

    public string? Indefinite { get; set; }

    public string? RetDesc { get; set; }

    public DateTime? RetCreated { get; set; }

    public string? RetActive { get; set; }
}
