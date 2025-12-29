using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class IlrAdditionalField
{
    public bool? Borninuk { get; set; }

    public string? Hllivedinuk { get; set; }

    public int Borno { get; set; }

    public string? Prelivedcountry { get; set; }

    public string? Hllivedinprecountry { get; set; }

    public bool? Ukpassport { get; set; }

    public bool? Visarequired { get; set; }

    public string? Typeofvisa { get; set; }

    public DateOnly? Expiredateofvisa { get; set; }

    public string? Countryofdomicile { get; set; }

    public string? Visaorppno { get; set; }

    public string? Evidenceseen { get; set; }

    public string? Initials { get; set; }

    public string? Preeducation { get; set; }

    public string? Whowillpay { get; set; }

    public string? Howtopay { get; set; }

    public bool? Employauth { get; set; }

    public bool? Advlladvice { get; set; }

    public bool? Advlapplied { get; set; }

    public string? Ninumseenby { get; set; }

    public DateOnly? Ninumdate { get; set; }

    public bool? Depbenefit { get; set; }

    public bool? Asylumseeker { get; set; }

    public bool? Lowincome { get; set; }

    public string? Preemployername { get; set; }

    public string? Preempaddress { get; set; }

    public string? Preemppostcode { get; set; }

    public bool? Unspentcriminal { get; set; }

    public string? Statsbenefitnotes { get; set; }

    public string? Firstlanguage { get; set; }

    public bool? Fulltimeedu { get; set; }
}
