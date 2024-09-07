using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerAnalyzerDestOrig1
    {
        public string? DestinationCntry { get; set; }
        public string PathId { get; set; } = null!;
        public string? Cntry { get; set; }
        public int? Cnt { get; set; }
        public double? ListPrice { get; set; }
        public double? NetPrice { get; set; }
        public string PathType { get; set; } = null!;
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
