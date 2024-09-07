using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiPartnerSummaryVw
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public int? ShpSoCnt { get; set; }
        public int? ShpSnCnt { get; set; }
        public int? ShpSnWithSvc { get; set; }
        public int? ShpSvcEligibleCnt { get; set; }
        public decimal? SvcAttachedRate { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerTheater { get; set; }
        public DateTime? Customersince { get; set; }
        public int? DivCnt { get; set; }
        public decimal? DivListAmt { get; set; }
        public decimal? DivNetAmt { get; set; }
        public decimal? DivMarginLoss { get; set; }
        public string? NsFlag { get; set; }
    }
}
