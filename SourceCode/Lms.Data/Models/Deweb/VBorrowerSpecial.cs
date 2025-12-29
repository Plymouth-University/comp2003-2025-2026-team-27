using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBorrowerSpecial
{
    public string? BorEmail { get; set; }

    public int? BorNo { get; set; }

    public string? BorBarNo { get; set; }

    public string? BorGiven { get; set; }

    public string? BorSurname { get; set; }

    public string? BorTitle { get; set; }

    public int SerialNum { get; set; }

    public string CatOfProcedure { get; set; } = null!;

    public DateTime DateOfOperation { get; set; }

    public int? Surveyid { get; set; }
}
