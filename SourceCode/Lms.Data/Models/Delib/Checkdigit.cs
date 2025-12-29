using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Checkdigit
{
    public int? CdLength { get; set; }

    public int? CdStartChars { get; set; }

    public int? CdEndChars { get; set; }

    public string? CdUse { get; set; }

    public string? CdWeights { get; set; }

    public int? CdModulus { get; set; }

    public string? CdType { get; set; }

    public string? CdLeading { get; set; }

    public string? CdTrailing { get; set; }

    public string? CdUnusual { get; set; }

    public int? CdUnique { get; set; }
}
