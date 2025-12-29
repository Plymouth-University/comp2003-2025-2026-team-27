using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AEvent
{
    public int AEvent1 { get; set; }

    /// <summary>
    /// USER ID
    /// </summary>
    public int AAnsUser { get; set; }

    /// <summary>
    /// THE TYPE OF THE EVENT
    /// </summary>
    public string EventType { get; set; } = null!;

    /// <summary>
    /// DATE AND TIME WHEN THE EVENT TOOK PLACE
    /// </summary>
    public DateTime EventDate { get; set; }

    /// <summary>
    /// DATE AND TIME WHEN THE SAME EVENT WAS MODIFIED
    /// </summary>
    public DateTime? ModEventDate { get; set; }

    public virtual AAnsUser AAnsUserNavigation { get; set; } = null!;
}
