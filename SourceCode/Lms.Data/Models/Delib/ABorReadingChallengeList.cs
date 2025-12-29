using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ABorReadingChallengeList
{
    public string BorBarNo { get; set; } = null!;

    public int ChallengeCatNo { get; set; }

    public string DeleteFlag { get; set; } = null!;

    public int? CurrentYear { get; set; }
}
