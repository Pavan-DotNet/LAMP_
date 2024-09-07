using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeSummaryMeasure
    {
        public string? FiscalQtr { get; set; }
        public string? ProductId { get; set; }
        public string? EcCountryCode { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public int? SnShippedCnt { get; set; }
        public decimal? ListAmt { get; set; }
        public decimal? NetAmt { get; set; }
        public int? SnWithSvc { get; set; }
        public decimal? NetAmtWithSvc { get; set; }
    }
}
