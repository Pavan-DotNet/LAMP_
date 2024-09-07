using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampServiceContract
    {
        public int ImportId { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractType { get; set; }
        public int? ContractItemNo { get; set; }
        public DateTime? ContractCreationDate { get; set; }
        public string? ContractStatus { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string? SalesOrderAlpha { get; set; }
        public string? InstalledAtKey { get; set; }
        public string? InstalledAtName { get; set; }
        public string? InstalledAtDistrict { get; set; }
        public string? InstalledAtCountryCode { get; set; }
        public string? InstalledAtCountryName { get; set; }
        public string? EndCustKey { get; set; }
        public string? EndCustName { get; set; }
        public string? EndCustDistrict { get; set; }
        public string? EndCustCountryCode { get; set; }
        public string? EndCustCountryName { get; set; }
        public string? BilltoKey { get; set; }
        public string? BilltoName { get; set; }
        public string? BilltoCity { get; set; }
        public string? BilltoCountryCode { get; set; }
        public string? BilltoCountryName { get; set; }
        public string? PayerKey { get; set; }
        public string? PayerName { get; set; }
        public string? PayerCity { get; set; }
        public string? PayerCountry { get; set; }
        public string? MaterialKey { get; set; }
        public string? MaterialDesc { get; set; }
        public string? ServiceMaterialKey { get; set; }
        public string? ServiceMaterialDesc { get; set; }
        public string? ServiceMaterialProductLine { get; set; }
        public string? ProductLine { get; set; }
        public string? ProductFamily { get; set; }
        public string? MaterialEccn { get; set; }
        public string? MaterialHts { get; set; }
        public string? IObjectId { get; set; }
        public string? SerialNumber { get; set; }
        public string? SerialNumberOrig { get; set; }
        public string? ContractLineItemStatus { get; set; }
        public string? Currency { get; set; }
        public decimal? ExtendedListPrice { get; set; }
        public string? DiscountDoNoUse { get; set; }
        public decimal? NetValue { get; set; }
        public DateTime? ImportDate { get; set; }
        public string? ExportedFlag { get; set; }
    }
}
