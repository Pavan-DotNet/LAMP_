using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeCustomersMaster
    {
        public int Id { get; set; }
        public string? EntityKey { get; set; }
        public string? CustName { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public string? Street3 { get; set; }
        public string? Street4 { get; set; }
        public string? Street5 { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? EntityType { get; set; }
        public string? EntitySource { get; set; }
        public string? Attribute1 { get; set; }
        public string? Attribute2 { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? GId { get; set; }
    }
}
