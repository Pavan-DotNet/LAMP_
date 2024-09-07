using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ResellerMissing
    {
        public string? ResellerName { get; set; }
        public string? ResellerCountryName { get; set; }
        public string PoType { get; set; } = null!;
    }
}
