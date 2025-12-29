using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CatDynamicTemplate
{
    public string LibGroup { get; set; } = null!;

    public string TemplateId { get; set; } = null!;

    public string LabelDesc { get; set; } = null!;

    public int? MarcTag { get; set; }

    public string? CurrentTemplate { get; set; }

    public string Subfield { get; set; } = null!;

    public string? ContentType { get; set; }

    public string? ContentStyle { get; set; }

    public string OpacShow { get; set; } = null!;

    public string? KwordSearch { get; set; }

    public bool? LookupOnly { get; set; }

    public string? TagLabelDesc { get; set; }

    public int? MarcTagGroupId { get; set; }

    public bool Searchable { get; set; }

    public int Pkid { get; set; }
}
