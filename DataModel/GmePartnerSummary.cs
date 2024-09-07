using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmePartnerSummary
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
        public string? ResellerAddress { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerTheater { get; set; }
        public DateTime? Customersince { get; set; }
        public string Resellerrole { get; set; } = null!;
        public string Accountgroup { get; set; } = null!;
        public string VarId { get; set; } = null!;
        public string Duns { get; set; } = null!;
        public string SfdcId { get; set; } = null!;
        public string? PartnerLevel { get; set; }
        public string? PartnerStatus { get; set; }
        public string? DplFlag { get; set; }
        public string? SplFlag { get; set; }
        public DateTime? RefreshedDate { get; set; }
        public string? RefreshDataRange { get; set; }
        public string? NsFlag { get; set; }
    }
}
