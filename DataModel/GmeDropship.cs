using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeDropship
    {
        public string? DeliveryNumber { get; set; }
        public int? DeliveryItem { get; set; }
        public string? DeliveryType { get; set; }
        public string? DeliveryDate { get; set; }
        public string? SoNumber { get; set; }
        public int? SoItem { get; set; }
        public string? ShpSoType { get; set; }
        public string? SoDate { get; set; }
        public string? PoType { get; set; }
        public string? ShipMaterial { get; set; }
        public string? MaterialOfferingType { get; set; }
        public string? MaterialType { get; set; }
        public string? ShpSn { get; set; }
        public string? ListPrice { get; set; }
        public string? TotNetPrice { get; set; }
        public string? Qty { get; set; }
        public string? UnitNetPrice { get; set; }
        public string? SoldtoName { get; set; }
        public string? SoldtoCountry { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ShiptoCustomer { get; set; }
        public string? ShiptoCountry { get; set; }
        public string? EndUserName { get; set; }
        public string? SameEndCustInDifferentCountry { get; set; }
        public string? EndUserCountry { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractType { get; set; }
        public int? ContractItemNo { get; set; }
        public string? ContractCreationDate { get; set; }
        public string? ContractStatus { get; set; }
        public string? ServiceStartDate { get; set; }
        public string? ServiceEndDate { get; set; }
        public string? EndCustName { get; set; }
        public string? EndCustCountryCode { get; set; }
        public string? SvcMaterial { get; set; }
        public string? Material { get; set; }
        public string? ServiceMaterialKey { get; set; }
        public string? ServiceMaterial { get; set; }
        public string? SvcSn { get; set; }
        public string? ContractLineItemStatus { get; set; }
        public string? AmSoNumber { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerDistrict { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerPartnerLevelKey { get; set; }
        public string? SoldtoPartyGsaFlag { get; set; }
        public string? ResellerGsaFlag { get; set; }
        public string? EndCustomerGsaFlag { get; set; }
        public string? EndCustomerPartnerLevel { get; set; }
        public string? TransactionCreated { get; set; }
        public string? AccountManager { get; set; }
        public string? AccountManagerCountry { get; set; }
    }
}
