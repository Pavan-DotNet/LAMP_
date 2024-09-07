using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampBpProfile
    {
        public int Id { get; set; }
        public string Bpid { get; set; } = null!;
        public bool? ProfileFlag { get; set; }
        public DateTime? LastProfiledDate { get; set; }
        public bool? GovtFlag { get; set; }
        public bool? UndeterminedFlag { get; set; }
        public bool? MilitaryFlag { get; set; }
        public bool? LawEnforcementFlag { get; set; }
        public bool? IsNameChanged { get; set; }
        public bool? IsStreetChanged { get; set; }
        public bool? IsCityChanged { get; set; }
        public bool? IsCountryChanged { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? CommercialRestricted { get; set; }
        public bool? DutchExpLicenseCty { get; set; }
        public bool? DutchBrokerNotifCty { get; set; }
        public bool? ExistingEu { get; set; }
        public bool? LicenseException { get; set; }
        public bool? ElaEligible { get; set; }
        public bool? IvlRequired { get; set; }
        public bool? SvcProvider { get; set; }
        public bool? EucRequired { get; set; }
        public string? TrnxType { get; set; }
        public string? TrnxChanged { get; set; }
        public bool? Watchlist { get; set; }
        public bool? Ftz { get; set; }
        public bool? ConsigneeUndertakingReq { get; set; }
        public string? DutchExpRisk { get; set; }
        public string? ComplianceStatus { get; set; }
        public string? SuppGroup { get; set; }
        public bool? SgConsigneeUndertaking { get; set; }
        public bool? NlExportRestriction { get; set; }
        public bool? TrueEndUser { get; set; }
        public int? LastestId { get; set; }
        public string? Profiledby { get; set; }
        public bool? MilitaryLawEnforcement { get; set; }
    }
}
