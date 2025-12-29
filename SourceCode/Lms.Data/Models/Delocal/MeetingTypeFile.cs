using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MeetingTypeFile
{
    public int MeetingTypeFileId { get; set; }

    public string? MeetingType { get; set; }

    public int FileId { get; set; }

    public string? FileDesc { get; set; }

    public int Mandatory { get; set; }
}
