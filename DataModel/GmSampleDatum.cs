using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmSampleDatum
    {
        public string? SoNumber { get; set; }
        public string? SoItem { get; set; }
        public string? SoType { get; set; }
        public DateTime? SoDate { get; set; }
        public string? PoType { get; set; }
        public string? DeliveryNumber { get; set; }
        public string? DeliveryItem { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SerialNumber { get; set; }
        public string? Material { get; set; }
        public double? ListPrice { get; set; }
        public double? NetValue { get; set; }
        public double? Discount { get; set; }
        public string? Quantity { get; set; }
        public string? CustomerGroup { get; set; }
        public string? EuShpPosCustomerKey { get; set; }
        public string? EuShpPosCustomerName { get; set; }
        public string? EuShpPosCustomerCountry { get; set; }
        public string? EuSvcContractCustomerKey { get; set; }
        public string? EuSvcContractCustomerName { get; set; }
        public string? EuSvcContractCustomerCountry { get; set; }
        public string? EuSvcContractCustomerCountryCode { get; set; }
        public string? DistributorName { get; set; }
        public string? DistributorCountry { get; set; }
        public string? DistributorCountryCode { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? GmFlag { get; set; }
        public string? GmReason { get; set; }
        public string? DiversionType { get; set; }
        public string? RmaFlag { get; set; }
        public string? EeaFlag { get; set; }
        public string? MspFlag { get; set; }
        public string? DplFlag { get; set; }
        public string? EcCompetitorFlag { get; set; }
        public string? EcWatchlistFlag { get; set; }
        public string? CndFlag { get; set; }
        public string? ReEcCountryMismatchFlag { get; set; }
        public string? ReTerritoryFlag { get; set; }
        public string? CustomerMatchConfidence { get; set; }
    }
}
