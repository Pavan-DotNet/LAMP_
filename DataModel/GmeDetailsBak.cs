using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeDetailsBak
    {
        public long? Id { get; set; }
        public string? ChannelModel { get; set; }
        public string? SerialNumber { get; set; }
        public string? ProductId { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountry { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerTheater { get; set; }
        public string? EcCustomer { get; set; }
        public string? EcCountry { get; set; }
        public string? EcCountryCode { get; set; }
        public string? EcTheater { get; set; }
        public double? EcLatitude { get; set; }
        public double? EcLongitude { get; set; }
        public string? SvcCustomer { get; set; }
        public string? SvcCountry { get; set; }
        public string? SvcCountryCode { get; set; }
        public string? SvcTheater { get; set; }
        public double? SvcLatitude { get; set; }
        public double? SvcLongitude { get; set; }
        public string? SoNumber { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? DeliveryNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SameEndCustFlag { get; set; }
        public string? TransactionItem { get; set; }
        public string? TransactionType { get; set; }
        public int? SoItem { get; set; }
        public string? SoType { get; set; }
        public DateTime? SoDate { get; set; }
        public string? PoType { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractType { get; set; }
        public string? ContractItemNo { get; set; }
        public DateTime? ContractCreationDate { get; set; }
        public string? ContractStatus { get; set; }
        public DateTime? ContractLineStartDate { get; set; }
        public DateTime? ContractEndStartDate { get; set; }
        public string? SvcMaterialKey { get; set; }
        public string? ContractLineItemStatus { get; set; }
        public string? AccountManager { get; set; }
        public string? AmCountry { get; set; }
        public string? AmCountryCode { get; set; }
        public string? AmTheater { get; set; }
        public string? DistiName { get; set; }
        public string? DistiCountry { get; set; }
        public string? DistiCountryCode { get; set; }
        public string? DistiTheater { get; set; }
        public double? EcSvcJaroScore { get; set; }
        public double? ResSvcJaroScore { get; set; }
        public double? ResEcJaroScore { get; set; }
        public string? EcGblGroupCompare { get; set; }
        public double? EcGblJaroScore { get; set; }
        public string? SvcGblGroupCompare { get; set; }
        public double? SvcGblJaroScore { get; set; }
        public string? ResGblGroupCompare { get; set; }
        public double? ResGblJaroScore { get; set; }
        public double? MaxGblScore { get; set; }
        public string? DiversionType { get; set; }
        public string? PartnerLevelKey { get; set; }
        public int MspScore { get; set; }
        public int? EcSvcSenzingScore { get; set; }
        public int? ResSvcSenzingScore { get; set; }
        public int? ResEcSenzingScore { get; set; }
        public string? EntityExceptionFlag { get; set; }
        public long? DedupId { get; set; }
        public string? TransactionNumber { get; set; }
    }
}
