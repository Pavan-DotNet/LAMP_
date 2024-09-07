using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PosNewprice
    {
        public int? PosId { get; set; }
        public decimal? TotNetPrice { get; set; }
        public decimal? ClaimAmt { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? AccountManager { get; set; }
        public string? SerialNumber { get; set; }
    }
}
