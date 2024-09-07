using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeMeasurePartnerSo
    {
        public string? ResellerKey { get; set; }
        public string? SoNumber { get; set; }
        public int? ShpSnCntByResSo { get; set; }
        public int? ShpSvcEligibleCntByResSo { get; set; }
        public decimal? ShpListAmt { get; set; }
        public decimal? ShpNetAmt { get; set; }
        public int? ShpSnWithSvcByResSo { get; set; }
        public decimal? ListAmtWithSvcByResSo { get; set; }
        public decimal? NetAmtWithSvcByResSo { get; set; }
        public string? ResellerName { get; set; }
    }
}
