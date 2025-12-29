using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CatalogueElectronic
{
    public int CatElectronicId { get; set; }

    public int CattagAuthNo { get; set; }

    public DateTime? UploadDatetime { get; set; }

    public DateTime? FileDatetime { get; set; }

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public long? FileLength { get; set; }

    public string FilterExtension { get; set; } = null!;

    public byte[]? FileData { get; set; }

    public string? PhysicalFileName { get; set; }
}
