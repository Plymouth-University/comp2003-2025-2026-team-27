using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Convertfile
{
    public DateTime? ConvEndtime { get; set; }

    public DateTime? ConvStarttime { get; set; }

    public string? Convfilename { get; set; }

    public int? ConvStartfrom { get; set; }

    public int? ConvDothismany { get; set; }

    public string? Convpath { get; set; }

    public string? ConvOrder { get; set; }

    public string? ConvItemonly { get; set; }

    public string? ConvDepritem { get; set; }

    public string? ConvAveprice { get; set; }

    public string? ConvInprocess { get; set; }

    public int? ConvDone { get; set; }
}
