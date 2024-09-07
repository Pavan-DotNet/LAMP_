using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class RawBookingsReseller
    {
        public int ImportId { get; set; }
        public string? So { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCity { get; set; }
        public string? ResellerCountry { get; set; }
        public DateTime? SoCreatedOn { get; set; }
        public DateTime? ImportDate { get; set; }
        public string? ImportStatus { get; set; }
    }
}
