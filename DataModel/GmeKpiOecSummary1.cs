using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiOecSummary1
    {
        public string? EndCustKey { get; set; }
        public string? EndcustName { get; set; }
        public int? ShpSoCnt { get; set; }
        public int? ShpSnCnt { get; set; }
        public int? ShpSnWithSvc { get; set; }
        public int? ShpSvcEligibleCnt { get; set; }
        public decimal? SvcAttachedRate { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public string? EndcustCountryCode { get; set; }
        public string? EndcustCountry { get; set; }
        public string? EndcustTheater { get; set; }
        public int? Customersince { get; set; }
        public int? DivCnt { get; set; }
        public decimal? DivListAmt { get; set; }
        public decimal? DivNetAmt { get; set; }
        public string? NsFlag { get; set; }
    }
}
