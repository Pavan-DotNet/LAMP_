using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeCustomersSenzing1
    {
        public string EntityType { get; set; } = null!;
        public string? EntityKey { get; set; }
        public string? EntityName1 { get; set; }
        public string? Street1 { get; set; }
        public string? Street2 { get; set; }
        public string? Street3 { get; set; }
        public string? Street4 { get; set; }
        public string? Street5 { get; set; }
        public string? City { get; set; }
        public string? CountryCode { get; set; }
        public string? EntitySource { get; set; }
        public string? CountryName { get; set; }
        public int? Id { get; set; }
        public string? PId { get; set; }
        public int? ResolvedEntityId { get; set; }
        public string? RelatedEntityIds { get; set; }
    }
}
