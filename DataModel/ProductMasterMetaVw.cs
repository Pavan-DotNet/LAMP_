using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ProductMasterMetaVw
    {
        public string? ProductId { get; set; }
        public string? ProductReleaseStatus { get; set; }
        public DateTime? ProductCreatedDate { get; set; }
        public string? ProductTypeText { get; set; }
        public string? ProductTypeCode { get; set; }
        public string? ProductType { get; set; }
        public string? ServiceEligible { get; set; }
        public string? ProductTypeDescription { get; set; }
        public string? ProductCategory { get; set; }
        public string? ProductLine { get; set; }
        public string? ProductFamily { get; set; }
        public string? ProductShortDesc { get; set; }
        public string? ProductLongDesc { get; set; }
        public string? OverLengthPartNumber { get; set; }
        public DateTime? EosDate { get; set; }
        public string? EosIndicator { get; set; }
        public string? EolIndicator { get; set; }
        public DateTime? EolDate { get; set; }
        public string? UsHts { get; set; }
        public string? ZNlHts { get; set; }
        public string? ZUsEccn { get; set; }
        public string? ZEuEccn { get; set; }
        public string? HsnCode { get; set; }
        public string? HsnDescription { get; set; }
        public string? ZCcats { get; set; }
        public string? ZMCcats { get; set; }
        public string? Uom { get; set; }
        public string? ProdGrossWeight { get; set; }
        public string? ProdNetWeight { get; set; }
        public string? ProdLength { get; set; }
        public string? ProdWidth { get; set; }
        public string? ProdHeight { get; set; }
        public string? ProdDimensions { get; set; }
    }
}
