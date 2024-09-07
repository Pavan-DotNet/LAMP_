using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiPartnerAnalyzerVw
    {
        public string? PResellerKey { get; set; }
        public string? PResellerName { get; set; }
        public int? PShpSoCnt { get; set; }
        public int? PShpSnCnt { get; set; }
        public int? PShpSnWithSvc { get; set; }
        public int? PShpSvcEligibleCnt { get; set; }
        public decimal? PSvcAttachedRate { get; set; }
        public decimal? PShpListAmt { get; set; }
        public decimal? PShpNetAmt { get; set; }
        public string? PResellerCountryCode { get; set; }
        public string? PResellerCountryName { get; set; }
        public string? PResellerTheater { get; set; }
        public DateTime? PCustomersince { get; set; }
        public int? PDivCnt { get; set; }
        public decimal? PDivListAmt { get; set; }
        public int? PDivNetAmt { get; set; }
        public decimal? PDivRate { get; set; }
    }
}
