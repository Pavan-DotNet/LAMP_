using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ProductClassification1
    {
        public string ProductId { get; set; } = null!;
        public string? ProductDescription { get; set; }
        public string? UsHts { get; set; }
        public string? ZUsEccn { get; set; }
        public string? ZEuEccn { get; set; }
        public string? ZCcats { get; set; }
        public string? ProductFamily { get; set; }
    }
}
