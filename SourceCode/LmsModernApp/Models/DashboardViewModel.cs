using System;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class DashboardViewModel
    {
        // Existing dashboard summary fields (your Index.cshtml expects these)
        public int TotalMemberCount { get; set; }
        public int TotalBookCount { get; set; }

        // Date range for issue search
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        // Chart data
        public List<string> Labels { get; set; } = new();
        public List<int> Values { get; set; } = new();
    }
}
