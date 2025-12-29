using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthNote
{
    public int? AuthNoteNo { get; set; }

    public string? AuthNoteData { get; set; }

    public string? AuthNoteOper { get; set; }

    public DateTime? AuthNoteDatetime { get; set; }

    public string? AuthNoteDiacrit { get; set; }
}
