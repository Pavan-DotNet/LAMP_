using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmePartnerSummary11
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public double? SalesAchievement { get; set; }
        public int? TotBookingQty { get; set; }
        public string? ShpResellerKey { get; set; }
        public string? ShpResellerName { get; set; }
        public decimal? TotListAmt { get; set; }
        public decimal? TotNetAmt { get; set; }
        public int? TotSnCnt { get; set; }
        public int? TotSnWithSvc { get; set; }
        public int? TotSoCnt { get; set; }
    }
}
