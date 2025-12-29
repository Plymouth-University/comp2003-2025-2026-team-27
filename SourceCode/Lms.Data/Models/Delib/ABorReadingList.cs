using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ABorReadingList
{
    public string? BorBarNo { get; set; }

    public long ListId { get; set; }

    public string ListName { get; set; } = null!;

    public int? SubTypeId { get; set; }

    public string DeleteFlag { get; set; } = null!;

    public string? DefaultList { get; set; }

    public string? ListDescription { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ListType { get; set; }

    public int? BorNo { get; set; }

    public virtual ICollection<ACatReadingList> ACatReadingLists { get; set; } = new List<ACatReadingList>();
}
