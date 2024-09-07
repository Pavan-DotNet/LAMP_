﻿using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeFilterAnalysisBak
    {
        public string? DiversionType { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountry { get; set; }
        public string? EcCustomer { get; set; }
        public string? EcCountry { get; set; }
        public string? SvcCustomer { get; set; }
        public string? SvcCountry { get; set; }
        public double? EcSvcJaroScore { get; set; }
        public double? ResEcJaroScore { get; set; }
        public double? MaxGblScore { get; set; }
        public int MspScore { get; set; }
    }
}
