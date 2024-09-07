using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ProductMaster
    {
        public string? ProductReleaseStatus { get; set; }
        public string? ProductCreatedDate { get; set; }
        public string? MaterialType { get; set; }
        public string? MaterialTypeDescription { get; set; }
        public string? ProductId { get; set; }
        public string? MaterialProductFamilyText { get; set; }
        public string? ProductDescription { get; set; }
        public string? OverLengthPartNumber { get; set; }
        public string? EosDate { get; set; }
        public string? EosIndicator { get; set; }
        public string? EolIndicator { get; set; }
        public string? EolDate { get; set; }
        public string? UsHts { get; set; }
        public string? ZNlHts { get; set; }
        public string? ZUsEccn { get; set; }
        public string? ZEuEccn { get; set; }
        public string? ZCcats { get; set; }
        public string? ZMCcats { get; set; }
        public string? Uom { get; set; }
        public string? GrossWeight { get; set; }
        public string? NetWeight { get; set; }
        public string? Length { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public string? Dimensions { get; set; }
    }
}
