using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class SurveySmileyFaceImage
{
    public int UniqueId { get; set; }

    public string SmileyFaceDesc { get; set; } = null!;

    public string ImgType { get; set; } = null!;

    public string ImgFilename { get; set; } = null!;

    public byte[] ImgData { get; set; } = null!;

    public string? ImgTypeHc { get; set; }

    public string? ImgFilenameHc { get; set; }

    public byte[]? ImgDataHc { get; set; }

    public string? ImgTypeBw { get; set; }

    public string? ImgFilenameBw { get; set; }

    public byte[]? ImgDataBw { get; set; }
}
