using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerAnalyzerDistiDrsp
    {
        public string? DeliveryNumber { get; set; }
        public string? DeliveryItem { get; set; }
        public string? DeliveryType { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SoNumber { get; set; }
        public string? SoType { get; set; }
        public string? PoType { get; set; }
        public string? ProductId { get; set; }
        public string? ProductSerialNumberSales { get; set; }
        public string? F10 { get; set; }
        public string? SerialNumber { get; set; }
        public double? ListPrice { get; set; }
        public double? NetValue { get; set; }
        public double? Quantity { get; set; }
        public string? SoldToKey { get; set; }
        public string? SoldToName { get; set; }
        public string? SoldToCountry { get; set; }
        public string? CustomerGroup { get; set; }
        public string? EndUserKey { get; set; }
        public string? EndCustomerSales { get; set; }
        public string? EndCustomerCountrySales { get; set; }
        public string? EndCustomer { get; set; }
        public string? EndCustomerServices { get; set; }
        public string? EndCustomerCountryServices { get; set; }
        public bool EuCountryMismatch { get; set; }
        public string? ResellerKey { get; set; }
        public string? IvarName { get; set; }
        public string? IvarCountry { get; set; }
    }
}
