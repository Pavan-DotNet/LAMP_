using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class CustProfiling
    {
        public string? Bpid { get; set; }
        public string? Name { get; set; }
        public string? Street { get; set; }
        public string? CreatedOn { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public DateTime? LastUpdatedOn { get; set; }
    }
}
