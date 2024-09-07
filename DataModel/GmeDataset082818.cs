using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeDataset082818
    {
        public string? ChannelModel { get; set; }
        public string DiversionType { get; set; } = null!;
        public int DrspPosId { get; set; }
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
        public string? SvcEligibleFlag { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? DiscPerc { get; set; }
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
        public string? EndCustTheater { get; set; }
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
        public string? ResellerTheater { get; set; }
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
        public string? DistiTheater { get; set; }
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
        public string? ProcessedFlag { get; set; }
        public string? AccountManager { get; set; }
        public string? AmCountryCode { get; set; }
        public string? AmCountryName { get; set; }
        public string? AmTheater { get; set; }
        public string? SvcContractNumber { get; set; }
        public string? SvcContractStatus { get; set; }
        public DateTime? SvcContractCreationDate { get; set; }
        public string? SvcContractType { get; set; }
        public DateTime? SvcStartDate { get; set; }
        public DateTime? SvcEndDate { get; set; }
        public string? SvcContractLineStatus { get; set; }
        public DateTime? SvcContractLineCreation { get; set; }
        public string? SvcSalesOrder { get; set; }
        public string? SvcMaterialKey { get; set; }
        public string? SvcMaterialDesc { get; set; }
        public decimal? SvcListValue { get; set; }
        public decimal? SvcNetValue { get; set; }
        public string? SvcCurrency { get; set; }
        public string? SvcInstalledAtKey { get; set; }
        public string? SvcInstalledAtName { get; set; }
        public string? SvcInstalledAtDistrict { get; set; }
        public string? SvcInstalledAtCountryCode { get; set; }
        public string? SvcInstalledAtCountryName { get; set; }
        public string? SvcEndCustKey { get; set; }
        public string? SvcEndCustName { get; set; }
        public string? SvcEndCustCity { get; set; }
        public string? SvcEndCustCountryCode { get; set; }
        public string? SvcEndCustCountryName { get; set; }
        public string? SvcEndCustTheater { get; set; }
        public string? SvcPayerKey { get; set; }
        public string? SvcPayerName { get; set; }
        public string? SvcPayerCountry { get; set; }
        public string? SvcBilltoKey { get; set; }
        public string? SvcBilltoName { get; set; }
        public string? SvcBilltoCountryCode { get; set; }
        public string? RmaNumber { get; set; }
        public string? QuoteId { get; set; }
        public string EcSvcKeyFlag { get; set; } = null!;
        public string ResEcKeyFlag { get; set; } = null!;
        public double? EcSvcJaroScore { get; set; }
        public double? ResEcJaroScore { get; set; }
        public int? GlobalAcctScore { get; set; }
        public string? EntityExceptionFlag { get; set; }
        public int EcSvcSenzingScore { get; set; }
        public int MspAcctScore { get; set; }
        public string? EcSvcSamegidFlag { get; set; }
        public string? EntityRelatedFlag { get; set; }
        public string ResSvcKeyFlag { get; set; } = null!;
        public double? ResSvcJaroScore { get; set; }
        public string? ResSvcEntityRelatedFlag { get; set; }
        public string? GmeFlag { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
