using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeBookingsSummary
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public double? SalesAchievement { get; set; }
        public int? BookingQty { get; set; }
    }
}
