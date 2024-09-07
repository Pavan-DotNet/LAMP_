using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class Set
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public double Score { get; set; }
        public string Value { get; set; } = null!;
        public DateTime? ExpireAt { get; set; }
    }
}
