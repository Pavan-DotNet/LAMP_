using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeKpiTargetTwb1
    {
        public string? EntityKey { get; set; }
        public string? EntityLevel { get; set; }
        public string? EntityName { get; set; }
        public string? EntityType { get; set; }
        public string? EntityCountry { get; set; }
        public string? EntityCountryCode { get; set; }
        public string? EntityTheater { get; set; }
        public DateTime? DateComplete { get; set; }
        public DateTime? DateOpened { get; set; }
        public string? QtrComplete { get; set; }
        public string? QtrOpened { get; set; }
        public string? Remediation { get; set; }
        public string? RemediationStatus { get; set; }
        public decimal? Recoveries { get; set; }
        public int? DivCnt { get; set; }
        public decimal? DivListAmt { get; set; }
        public decimal? DivNetAmt { get; set; }
        public decimal? DivMarginLoss { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public int? ShpSnCnt { get; set; }
        public int? ShpSnWithSvc { get; set; }
        public int? ShpSvcEligibleCnt { get; set; }
        public string? EmailForm { get; set; }
        public string? EmailSent { get; set; }
        public string? Notes { get; set; }
        public string? NsFlag { get; set; }
    }
}
