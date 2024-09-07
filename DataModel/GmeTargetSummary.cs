using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeTargetSummary
    {
        public string? ResellerName { get; set; }
        public string? ResellerCountryName { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerTheater { get; set; }
        public string? PoType { get; set; }
        public decimal? AmtProductsSold { get; set; }
        public int? TotLinesBooked { get; set; }
        public int? TotLinesWithSvc { get; set; }
        public decimal? ServiceAttachPerc { get; set; }
        public decimal? AmtProductsWithSvc { get; set; }
    }
}
