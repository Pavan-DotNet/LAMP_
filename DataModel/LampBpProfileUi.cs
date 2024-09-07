using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampBpProfileUi
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
        public bool? HighRisk { get; set; }
        public bool? Military { get; set; }
        public bool? LawEnforcement { get; set; }
        public bool? NameChanged { get; set; }
        public bool? StreetChanged { get; set; }
        public bool? CityChanged { get; set; }
        public bool? CountryChanged { get; set; }
        public string? Comments { get; set; }
        public string? TrnxType { get; set; }
        public string? TrnxChanged { get; set; }
        public int? GlobalProfileId { get; set; }
        public long? DedupId { get; set; }
    }
}
