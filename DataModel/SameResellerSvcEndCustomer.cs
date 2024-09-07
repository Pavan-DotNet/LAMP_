using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class SameResellerSvcEndCustomer
    {
        public string? SoNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? SvcContractNumber { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? EndCustKey { get; set; }
        public string? EndCustName { get; set; }
        public string? SvcEndCustKey { get; set; }
        public string? SvcEndCustName { get; set; }
        public string? GmeFlag { get; set; }
        public int? MspAcctScore { get; set; }
        public double? ResSvcJaroScore { get; set; }
    }
}
