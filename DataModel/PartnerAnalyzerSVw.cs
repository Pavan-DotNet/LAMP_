using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerAnalyzerSVw
    {
        public string? ChannelModel { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountryName { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerTheater { get; set; }
        public double? TotLinesBooked { get; set; }
        public double? AmtProductsSold { get; set; }
        public double? TotLinesWithSvc { get; set; }
        public double? ServiceAttachPerc { get; set; }
        public double? AmtProductsWithSvc { get; set; }
        public double? NumLinesCntryMismatch { get; set; }
        public double? DiversionPerc { get; set; }
        public double? NetAmtDiverted { get; set; }
        public double? ListAmtDiverted { get; set; }
        public double? DiscDivertedPerc { get; set; }
        public double? MarginLossPerc { get; set; }
        public double? MarginLossAmt { get; set; }
    }
}
