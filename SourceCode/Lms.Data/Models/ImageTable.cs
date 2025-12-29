using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ImageTable
{
    public int? CatNo { get; set; }

    public int? UniqueItemNo { get; set; }

    public int? BorNo { get; set; }

    public int? PictureNo { get; set; }

    public string? PictureString { get; set; }

    public string? PictureTitle { get; set; }
}
