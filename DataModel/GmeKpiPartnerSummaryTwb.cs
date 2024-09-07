using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiPartnerSummaryTwb
    {
        public string? ResellerName { get; set; }
        public string? ResellerKeys { get; set; }
        public int? ShpSnCnt { get; set; }
        public int? ShpSnWithSvc { get; set; }
        public int? ShpSvcEligibleCnt { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public int? DivCnt { get; set; }
        public decimal? DivListAmt { get; set; }
        public decimal? DivNetAmt { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerTheater { get; set; }
        public decimal? AttachedRate { get; set; }
    }
}
