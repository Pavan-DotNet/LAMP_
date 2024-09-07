using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ProductClassification080720191
    {
        public string ProductReleaseStatus { get; set; } = null!;
        public DateTime ProductCreatedDate { get; set; }
        public string MaterialTypeMediumText { get; set; } = null!;
        public string MaterialTypeCode { get; set; } = null!;
        public string? MaterialProductTypeKey { get; set; }
        public string MaterialTypeDescription { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public string ProductLine { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ShortDescription { get; set; } = null!;
        public string LongDescription { get; set; } = null!;
        public string OverLengthPartNumber { get; set; } = null!;
        public string? EosDate { get; set; }
        public string EosIndicator { get; set; } = null!;
        public string EolIndicator { get; set; } = null!;
        public string? EolDate { get; set; }
        public string? UsHts { get; set; }
        public string? ZUsEccn { get; set; }
        public string? ZEuEccn { get; set; }
        public int? HsnCode { get; set; }
        public string? HsnDescription { get; set; }
        public string? ZCcats { get; set; }
        public string Uom { get; set; } = null!;
    }
}
