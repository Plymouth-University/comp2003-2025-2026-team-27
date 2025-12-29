using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class VideoAnalytic
{
    public int Id { get; set; }

    public int CatNo { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public string? CatTitle { get; set; }
}
