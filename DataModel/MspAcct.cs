using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class MspAcct
    {
        public string SapId { get; set; } = null!;
        public string? AccountName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Status { get; set; }
        public string? Attribute1 { get; set; }
    }
}
