using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class QuoteSoMetric
    {
        public string? QuoteId { get; set; }
        public string? SoNumber { get; set; }
        public DateTime? QuoteCreationDate { get; set; }
        public DateTime? SoCreationDate { get; set; }
        public string? SoType { get; set; }
        public string? EndUserCountryCode { get; set; }
        public int? Qot2soDays { get; set; }
        public string? CountryName { get; set; }
        public string? Embargoed { get; set; }
        public string? ConsUndertakingRequired { get; set; }
        public string? NoGlobalLicForMilitaryEu { get; set; }
        public string? JuniperWatchList { get; set; }
        public string? UsnonSupp3 { get; set; }
        public string? NetherlandsBrokerNotif { get; set; }
        public string? HighRisk { get; set; }
        public string? MidRisk { get; set; }
        public string? LowRisk { get; set; }
    }
}
