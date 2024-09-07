using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeFalsePositive
    {
        public long Id { get; set; }
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? EntityParentKey { get; set; }
        public string? EntityParentName { get; set; }
        public string? ExceptionName { get; set; }
        public string? ExceptionKey { get; set; }
        public string? Datasource { get; set; }
        public string? NsFlag { get; set; }
    }
}
