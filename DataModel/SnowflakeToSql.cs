using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class SnowflakeToSql
    {
        public long? Index { get; set; }
        public long? CCustkey { get; set; }
        public string? CName { get; set; }
        public string? CAddress { get; set; }
        public long? CNationkey { get; set; }
        public string? CPhone { get; set; }
        public double? CAcctbal { get; set; }
        public string? CMktsegment { get; set; }
        public string? CComment { get; set; }
    }
}
