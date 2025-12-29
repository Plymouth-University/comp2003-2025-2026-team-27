using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorSpecial
{
    public int BorNo { get; set; }

    public int SerialNum { get; set; }

    public string CatOfProcedure { get; set; } = null!;

    public DateTime DateOfOperation { get; set; }

    public int? Surveyid { get; set; }
}
