using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class FullCustomer
    {
        public int Bpid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Archived { get; set; }
        public string? Name { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Cty { get; set; }
        public string? CtyGrp { get; set; }
        public string? BpGrp { get; set; }
        public string? BpRole { get; set; }
    }
}
