using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PaypalCountry
{
    public string CountryRegion { get; set; } = null!;

    public string CountryRegionCode { get; set; } = null!;

    public bool PostalCodeRequired { get; set; }
}
