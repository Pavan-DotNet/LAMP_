using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ServiceContractFebmar2018
    {
        public string ContractNumber { get; set; } = null!;
        public string ServiceContractType { get; set; } = null!;
        public string ContractItemNo { get; set; } = null!;
        public string? ContractCreationDate { get; set; }
        public string? ContractStatusText { get; set; }
        public string? ServiceStartDate { get; set; }
        public string? ServiceEndDate { get; set; }
        public string SalesOrderAlpha { get; set; } = null!;
        public string InstalledAtKey { get; set; } = null!;
        public string InstalledAtLongText { get; set; } = null!;
        public string InstalledAtBasDistrictText { get; set; } = null!;
        public string InstalledAtCountryKey { get; set; } = null!;
        public string EndCustomer { get; set; } = null!;
        public string EndCustomerDescription { get; set; } = null!;
        public string EndCustomerBasDistrictKey { get; set; } = null!;
        public string EndCustomerCountryKey { get; set; } = null!;
        public string BillToPartyKey { get; set; } = null!;
        public string BillToPartyLongText { get; set; } = null!;
        public string BillToPartyBasDistrictKey { get; set; } = null!;
        public string BillToPartyCountryText { get; set; } = null!;
        public string PayerKey { get; set; } = null!;
        public string PayerLongText { get; set; } = null!;
        public string PayerBasDistrictKey { get; set; } = null!;
        public string PayerCountryText { get; set; } = null!;
        public string MaterialKey { get; set; } = null!;
        public string MaterialText { get; set; } = null!;
        public string ServiceMaterialKey { get; set; } = null!;
        public string ServiceMaterial { get; set; } = null!;
        public string ServiceMaterialProductLineText { get; set; } = null!;
        public string ProductLine { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string MaterialEccnKey { get; set; } = null!;
        public string MaterialHtsKey { get; set; } = null!;
        public string IObjectId { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string ContractLineItemStatusDescription { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public string ExtendedListPriceDoNotUse { get; set; } = null!;
        public string DiscountDoNotUse { get; set; } = null!;
        public string NetValue { get; set; } = null!;
    }
}
