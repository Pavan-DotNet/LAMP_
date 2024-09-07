using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmePartnerAnalyzer1Twb
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
        public decimal? DivMarginLoss { get; set; }
        public decimal? AttachedRate { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerTheater { get; set; }
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? EntityType { get; set; }
        public string? EntityLevel { get; set; }
        public string? Remediation { get; set; }
        public string? RemediationStatus { get; set; }
        public decimal? Recoveries { get; set; }
        public DateTime? DateOpened { get; set; }
        public string? QtrOpened { get; set; }
        public DateTime? DateComplete { get; set; }
        public string? QtrComplete { get; set; }
        public string? EmailSent { get; set; }
        public string? EmailForm { get; set; }
        public string? Notes { get; set; }
    }
}
