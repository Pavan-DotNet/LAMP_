using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampBpProfile1
    {
        public int Id { get; set; }
        public string Bpid { get; set; } = null!;
        public bool? ProfileFlag { get; set; }
        public DateTime? LastProfiledDate { get; set; }
        public bool? GovtFlag { get; set; }
        public bool? HighriskElrFlag { get; set; }
        public bool? MilitaryFlag { get; set; }
        public bool? LawEnforcementFlag { get; set; }
        public bool? IsNameChanged { get; set; }
        public bool? IsStreetChanged { get; set; }
        public bool? IsCityChanged { get; set; }
        public bool? IsCountryChanged { get; set; }
        public string? Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Attribute1 { get; set; }
        public bool? Attribute2 { get; set; }
        public bool? Attribute3 { get; set; }
        public bool? Attribute4 { get; set; }
        public bool? Attribute5 { get; set; }
        public bool? Attribute6 { get; set; }
        public bool? Attribute7 { get; set; }
        public bool? Attribute8 { get; set; }
        public bool? Attribute9 { get; set; }
        public string? Attribute10 { get; set; }
        public string? Attribute11 { get; set; }
        public bool? Attribute12 { get; set; }
        public bool? Attribute13 { get; set; }
        public bool? Attribute14 { get; set; }
        public string? Attribute15 { get; set; }
        public string? Attribute16 { get; set; }
        public string? Attribute17 { get; set; }
        public string? Attribute18 { get; set; }
        public string? Attribute19 { get; set; }
        public string? Attribute20 { get; set; }
        public long? MaxBpid { get; set; }
    }
}
