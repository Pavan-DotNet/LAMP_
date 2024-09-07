using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class QuoteSoMap
    {
        public string? QuoteId { get; set; }
        public string? SoNumber { get; set; }
        public DateTime? QuoteCreationDate { get; set; }
        public DateTime? SoCreationDate { get; set; }
    }
}
