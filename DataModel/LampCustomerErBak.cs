using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampCustomerErBak
    {
        public int Id { get; set; }
        public string? EntityKey { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? CountryCode { get; set; }
        public int? GId { get; set; }
        public int? GuId { get; set; }
        public int? GpId { get; set; }
        public string? GblAcctFlag { get; set; }
        public string? MspAcctFlag { get; set; }
        public string? Status { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? BpmEndCustomer { get; set; }
        public string? ParentCustomerKey { get; set; }
        public string? ParentCustomer { get; set; }
        public string? UltimateParentKey { get; set; }
        public string? UltimateParent { get; set; }
        public string? GlobalUltimateParentKey { get; set; }
        public string? GlobalUltimateParent { get; set; }
    }
}
