using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ABorAddressType
{
    public short AddressTypeId { get; set; }

    public string AdddressTypeDescription { get; set; } = null!;
}
