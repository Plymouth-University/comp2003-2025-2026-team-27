using System;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class DashboardViewModel
    {
        // Existing dashboard summary fields
        public int TotalMemberCount { get; set; }
        public int TotalBookCount { get; set; }

        // Date range for issue search
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        // Chart data
        public List<string> Labels { get; set; } = new();
        public List<int> Values { get; set; } = new();
        public List<double> Percentages { get; set; } = new();

        // Trend data (Multi-series)
        public List<Lms.Data.TrendDto> Trends { get; set; } = new();

        // User File Sets for filtering
        public List<Lms.Data.Models.Delib.FileSetName> UserFiles { get; set; } = new();

        // Operators for filtering (visible when filter is User Counts)
        public List<Lms.Data.Models.Delocal.Operator> Operators { get; set; } = new();
    }
}
