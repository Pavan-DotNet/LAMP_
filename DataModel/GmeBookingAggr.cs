using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeBookingAggr
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public double? SalesAchievement { get; set; }
        public int? TotBookingQty { get; set; }
    }
}
