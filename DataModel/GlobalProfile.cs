using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GlobalProfile
    {
        public string? Bpid { get; set; }
        public string? CustName { get; set; }
        public string? CountryName { get; set; }
        public string? RelatedEntityId { get; set; }
        public string? RelatedEntityName { get; set; }
        public string? RelatedEntityCountry { get; set; }
        public double? JaroScore { get; set; }
    }
}
