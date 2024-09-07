using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeCustomersSenzing
    {
        public int? ResolvedEntityId { get; set; }
        public string? ResolvedEntityName { get; set; }
        public int? RelatedEntityId { get; set; }
        public int? MatchLevel { get; set; }
        public string? MatchKey { get; set; }
        public string? DataSource { get; set; }
        public string? RecordId { get; set; }
        public string? JsonData { get; set; }
        public int? Id { get; set; }
        public string? EntityKey { get; set; }
    }
}
