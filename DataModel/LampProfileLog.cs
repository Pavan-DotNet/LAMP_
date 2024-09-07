using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampProfileLog
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? TotIncrCustCnt { get; set; }
        public int? ProfileNewCnt { get; set; }
        public int? ProfileUpdatedCnt { get; set; }
        public int? IgnoredCnt { get; set; }
        public int? TotProfileProcessedCnt { get; set; }
        public string? Notes { get; set; }
    }
}
