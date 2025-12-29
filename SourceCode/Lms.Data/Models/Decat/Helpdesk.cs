using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class Helpdesk
{
    public int Helpdeskid { get; set; }

    public string? Username { get; set; }

    public string? Assignedto { get; set; }

    public string? Ticketstaus { get; set; }

    public string? Ticketmessage { get; set; }

    public string? Prioritytype { get; set; }

    public string? Matchingticket { get; set; }

    public string? Replymessage { get; set; }
}
