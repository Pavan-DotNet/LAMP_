using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class NsAvgDiscPerCountry
    {
        public string? EndCustCountryCode { get; set; }
        public string? EndCustCountry { get; set; }
        public double? TotListAmt { get; set; }
        public double? TotNetAmt { get; set; }
        public double? DiscPerc { get; set; }
    }
}
