using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ShipmentLineMetaVw
    {
        public int ImportId { get; set; }
        public string? DeliveryNumber { get; set; }
        public int? DeliveryItem { get; set; }
        public string? DeliveryType { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SoNumber { get; set; }
        public int? SoItem { get; set; }
        public string? SoType { get; set; }
        public DateTime? SoDate { get; set; }
        public string? PoType { get; set; }
        public string? Material { get; set; }
        public string? MaterialOfferingType { get; set; }
        public string? MaterialType { get; set; }
        public string? SerialNumber { get; set; }
        public string? MaterialEccn { get; set; }
        public string? MaterialHts { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? TotNetPrice { get; set; }
        public decimal? Qty { get; set; }
        public decimal? NetPrice { get; set; }
        public string? PlantKey { get; set; }
        public string? PlantName { get; set; }
        public string? SalesOrgKey { get; set; }
        public string? SalesOrgName { get; set; }
        public string? SoldtoKey { get; set; }
        public string? SoldtoName { get; set; }
        public string? SoldtoStreet1 { get; set; }
        public string? SoldtoStreet2 { get; set; }
        public string? SoldtoStreet3 { get; set; }
        public string? SoldtoStreet4 { get; set; }
        public string? SoldtoStreet5 { get; set; }
        public string? SoldtoCity { get; set; }
        public string? SoldtoCountry { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ShiptoKey { get; set; }
        public string? ShiptoCustomer { get; set; }
        public string? ShiptoStreet1 { get; set; }
        public string? ShiptoStreet2 { get; set; }
        public string? ShiptoStreet3 { get; set; }
        public string? ShiptoStreet4 { get; set; }
        public string? ShiptoStreet5 { get; set; }
        public string? ShiptoCity { get; set; }
        public string? ShiptoCountry { get; set; }
        public string? BilltoPartyKey { get; set; }
        public string? BilltoPartyName { get; set; }
        public string? BilltoPartyStreet1 { get; set; }
        public string? BilltoPartyStreet2 { get; set; }
        public string? BilltoPartyStreet3 { get; set; }
        public string? BilltoPartyStreet4 { get; set; }
        public string? BilltoPartyStreet5 { get; set; }
        public string? BilltoPartyCity { get; set; }
        public string? BilltoPartyCountry { get; set; }
        public string? EndUserKey { get; set; }
        public string? EndUserName { get; set; }
        public string? EndUserStreet1 { get; set; }
        public string? EndUserStreet2 { get; set; }
        public string? EndUserStreet3 { get; set; }
        public string? EndUserStreet4 { get; set; }
        public string? EndUserStreet5 { get; set; }
        public string? EndUserCity { get; set; }
        public string? EndUserCountry { get; set; }
        public DateTime? ImportDate { get; set; }
        public string? ImportStatus { get; set; }
    }
}
