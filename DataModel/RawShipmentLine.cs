using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class RawShipmentLine
    {
        public int ImportId { get; set; }
        public string? DeliveryNumber { get; set; }
        public string? DeliveryItem { get; set; }
        public string? DeliveryType { get; set; }
        public string? DeliveryDate { get; set; }
        public string? SoNumber { get; set; }
        public string? SoItem { get; set; }
        public string? SoType { get; set; }
        public string? SoDate { get; set; }
        public string? PoType { get; set; }
        public string? Material { get; set; }
        public string? MaterialOfferingType { get; set; }
        public string? MaterialType { get; set; }
        public string? SerialNumber { get; set; }
        public string? Eccn { get; set; }
        public string? Hts { get; set; }
        public string? ListPrice { get; set; }
        public string? NetValue { get; set; }
        public string? Quantity { get; set; }
        public string? PlantKey { get; set; }
        public string? PlantName { get; set; }
        public string? SalesOrgKey { get; set; }
        public string? SalesOrgName { get; set; }
        public string? SoldToKey { get; set; }
        public string? SoldToName { get; set; }
        public string? SoldToStreet1 { get; set; }
        public string? SoldToStreet2 { get; set; }
        public string? SoldToStreet3 { get; set; }
        public string? SoldToStreet4 { get; set; }
        public string? SoldToStreet5 { get; set; }
        public string? SoldToCity { get; set; }
        public string? SoldToCountry { get; set; }
        public string? CustomerGroup { get; set; }
        public string? ShipToKey { get; set; }
        public string? ShipToCustomer { get; set; }
        public string? ShipToStreet1 { get; set; }
        public string? ShipToStreet2 { get; set; }
        public string? ShipToStreet3 { get; set; }
        public string? ShipToStreet4 { get; set; }
        public string? ShipToStreet5 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToCountry { get; set; }
        public string? BillToPartyKey { get; set; }
        public string? BillToPartyName { get; set; }
        public string? BillToPartyStreet1 { get; set; }
        public string? BillToPartyStreet2 { get; set; }
        public string? BillToPartyStreet3 { get; set; }
        public string? BillToPartyStreet4 { get; set; }
        public string? BillToPartyStreet5 { get; set; }
        public string? BillToPartyCity { get; set; }
        public string? BillToPartyCountry { get; set; }
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
