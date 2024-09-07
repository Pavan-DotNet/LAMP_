using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeMeasureSo
    {
        public string? SoNumber { get; set; }
        public int? SnShippedCnt { get; set; }
        public decimal? ListAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public int? SnWithSvc { get; set; }
        public decimal? ListAmtWithSvc { get; set; }
        public decimal? NetAmtWithSvc { get; set; }
    }
}
