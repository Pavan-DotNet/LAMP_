using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampDrspPosMergedStg
    {
        public int Id { get; set; }
        public string? SourceTransaction { get; set; }
        public int? SourceImportId { get; set; }
        public string? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string? DeliveryItem { get; set; }
        public string? TransactionType { get; set; }
        public string? CustomerGroup { get; set; }
        public string PoType { get; set; } = null!;
        public string? SoNumber { get; set; }
        public string? SoNumberOrig { get; set; }
        public int? SoItem { get; set; }
        public string? SoType { get; set; }
        public DateTime? SoDate { get; set; }
        public string? SerialNumber { get; set; }
        public string? SerialNumberOrig { get; set; }
        public string? MaterialKey { get; set; }
        public string? MaterialDesc { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? EndCustKey { get; set; }
        public string? EndCustName { get; set; }
        public string? EndCustStreet1 { get; set; }
        public string? EndCustStreet2 { get; set; }
        public string? EndCustStreet3 { get; set; }
        public string? EndCustStreet4 { get; set; }
        public string? EndUserStreet5 { get; set; }
        public string? EndCustCity { get; set; }
        public string? EndCustRegion { get; set; }
        public string? EndCustPostalCode { get; set; }
        public string? EndCustCountryCode { get; set; }
        public string? EndCustCountry { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerStreet1 { get; set; }
        public string? ResellerStreet2 { get; set; }
        public string? ResellerStreet3 { get; set; }
        public string? ResellerStreet4 { get; set; }
        public string? ResellerCity { get; set; }
        public string? ResellerPostalCode { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerCountry { get; set; }
        public string? BilltoKey { get; set; }
        public string? BilltoName { get; set; }
        public string? BilltoStreet1 { get; set; }
        public string? BilltoStreet2 { get; set; }
        public string? BilltoStreet3 { get; set; }
        public string? BilltoStreet4 { get; set; }
        public string? BilltoStreet5 { get; set; }
        public string? BilltoDistrict { get; set; }
        public string? BilltoRegion { get; set; }
        public string? BilltoPostalCode { get; set; }
        public string? BilltoCountryCode { get; set; }
        public string? BilltoCountryName { get; set; }
        public string? DistiKey { get; set; }
        public string? DistiName { get; set; }
        public string? DistiStreet1 { get; set; }
        public string? DistiStreet2 { get; set; }
        public string? DistiStreet3 { get; set; }
        public string? DistiStreet4 { get; set; }
        public string? DistiRegion { get; set; }
        public string? DistiCity { get; set; }
        public string? DistiPostalCode { get; set; }
        public string? DistiCountryCode { get; set; }
        public string? DistiCountryName { get; set; }
        public string SoldtoKey { get; set; } = null!;
        public string? SoldtoName { get; set; }
        public string? SoldtoStreet1 { get; set; }
        public string? SoldtoStreet2 { get; set; }
        public string? SoldtoStreet3 { get; set; }
        public string? SoldtoStreet4 { get; set; }
        public string? SoldtoStreet5 { get; set; }
        public string? SoldtoCity { get; set; }
        public string? SoldtoPostalCode { get; set; }
        public string? SoldtoCountryCode { get; set; }
        public string? SoldtoCountryName { get; set; }
        public string ShiptoKey { get; set; } = null!;
        public string? ShiptoCustomer { get; set; }
        public string? ShiptoStreet1 { get; set; }
        public string? ShiptoStreet2 { get; set; }
        public string? ShiptoStreet3 { get; set; }
        public string? ShiptoStreet4 { get; set; }
        public string? ShiptoStreet5 { get; set; }
        public string? ShiptoCity { get; set; }
        public string? ShiptoPostalCode { get; set; }
        public string? ShiptoRegion { get; set; }
        public string? ShiptoCountryCode { get; set; }
        public string? ShiptoCountryName { get; set; }
        public int? ReportedQty { get; set; }
        public string? ClaimStatus { get; set; }
        public string? CiStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ProcessedFlag { get; set; }
        public string? AccountManager { get; set; }
    }
}
