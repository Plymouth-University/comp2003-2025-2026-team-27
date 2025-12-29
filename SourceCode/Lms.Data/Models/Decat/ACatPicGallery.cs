using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class ACatPicGallery
{
    public int CatNo { get; set; }

    public string CatPicType { get; set; } = null!;

    public string CatPicFilename { get; set; } = null!;

    public byte[] CatPicData { get; set; } = null!;

    public bool? MasterImg { get; set; }
}
