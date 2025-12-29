using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class WebsiteElectronic
{
    public int ElectronicId { get; set; }

    public DateTime? UploadDatetime { get; set; }

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public long? FileLength { get; set; }

    public byte[] FileData { get; set; } = null!;

    public string LibGroup { get; set; } = null!;

    public string Path { get; set; } = null!;
}
