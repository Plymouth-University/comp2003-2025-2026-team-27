using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ZwebPageCache
{
    public string? ZpcPageId { get; set; }

    public string? ZpcHtml { get; set; }

    public DateTime? ZpcDatetime { get; set; }
}
