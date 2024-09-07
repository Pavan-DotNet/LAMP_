using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class GmeBookingsShipment
    {
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? SoNumber { get; set; }
        public int? SoLineNum { get; set; }
        public string? MaterialKey { get; set; }
        public string? SerialNumber { get; set; }
        public string? Material { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? ContractNumber { get; set; }
        public string? ContractLineItemStatus { get; set; }
    }
}
