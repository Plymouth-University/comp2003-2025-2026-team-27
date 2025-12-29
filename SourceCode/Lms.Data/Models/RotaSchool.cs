using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class RotaSchool
{
    public int SgId { get; set; }

    public int BorNo { get; set; }

    public int? RsOrder { get; set; }

    public string? RsComments { get; set; }

    public virtual RotaSchoolGroup Sg { get; set; } = null!;
}
