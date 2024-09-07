using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ProfileTmpTable
    {
        public string TrnxType { get; set; } = null!;
        public string? Bpid { get; set; }
        public string? NameConc { get; set; }
        public string? StreetConc { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public int? IsNameChanged { get; set; }
        public int? IsStreetChanged { get; set; }
        public int? IsCityChanged { get; set; }
        public int? IsCountryChanged { get; set; }
        public string? TrnxChanged { get; set; }
    }
}
