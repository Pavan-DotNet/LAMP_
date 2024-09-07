using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampBpProfileVw
    {
        public string Bpid { get; set; } = null!;
        public bool? Profiled { get; set; }
        public DateTime? LastProfiledDate { get; set; }
        public string? CustName { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public bool? Govt { get; set; }
        public bool? Undetermined { get; set; }
        public bool? Military { get; set; }
        public bool? LawEnforcement { get; set; }
        public bool? NameChanged { get; set; }
        public bool? StreetChanged { get; set; }
        public bool? CityChanged { get; set; }
        public bool? CountryChanged { get; set; }
        public string? Comments { get; set; }
        public string? TrnxType { get; set; }
        public string? TrnxChanged { get; set; }
        public string? DutchExpRisk { get; set; }
        public string? SuppGroup { get; set; }
        public string DutchExpLicenseCty { get; set; } = null!;
        public bool? CommercialRestricted { get; set; }
        public string ConsigneeUndertakingReq { get; set; } = null!;
        public string DutchBrokerNotifCty { get; set; } = null!;
        public bool? ExistingEu { get; set; }
        public bool? LicenseException { get; set; }
        public bool? ElaEligible { get; set; }
        public bool? IvlRequired { get; set; }
        public bool? SvcProvider { get; set; }
        public bool? MilitaryLawEnforcement { get; set; }
        public bool? SgConsigneeUndertaking { get; set; }
        public string? NlExportRestriction { get; set; }
        public bool? TrueEndUser { get; set; }
        public bool? EucRequired { get; set; }
        public string? Watchlist { get; set; }
        public bool? Ftz { get; set; }
        public string? ComplianceStatus { get; set; }
        public string? Profiledby { get; set; }
    }
}
