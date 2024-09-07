using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeNewPartnerDomestic
    {
        public string? PoType { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public double? TotLinesBooked { get; set; }
        public double? AmtProductsSold { get; set; }
        public double? TotLinesWithService { get; set; }
        public double? ServiceAttachPerc { get; set; }
        public double? NetAmtWithService { get; set; }
    }
}
