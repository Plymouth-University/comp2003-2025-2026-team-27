using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ABorSavedSearch
{
    public string BorBarNo { get; set; } = null!;

    public long SearchesId { get; set; }

    public virtual ICollection<ABorSearch> ABorSearches { get; set; } = new List<ABorSearch>();
}
