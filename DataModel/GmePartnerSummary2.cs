using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmePartnerSummary2
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public int? TotSoCnt { get; set; }
        public int? TotSnCnt { get; set; }
        public decimal? TotListAmt { get; set; }
        public decimal? TotNetAmt { get; set; }
        public int? TotSnWithSvc { get; set; }
    }
}
