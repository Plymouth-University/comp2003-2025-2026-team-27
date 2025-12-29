using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AOpacBorWatchedVideo
{
    public string BorBarNo { get; set; } = null!;

    public int VideoCatNo { get; set; }

    public DateTime CreateDatetime { get; set; }
}
