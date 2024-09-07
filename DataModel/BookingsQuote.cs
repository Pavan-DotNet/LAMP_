using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class BookingsQuote
    {
        public string? SoNumber { get; set; }
        public DateTime? BookedDate { get; set; }
        public string? SoType { get; set; }
        public string? EndUserCountryCode { get; set; }
        public long? DedupId { get; set; }
    }
}
