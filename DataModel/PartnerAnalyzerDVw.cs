using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerAnalyzerDVw
    {
        public long? Id { get; set; }
        public string ChannelModel { get; set; } = null!;
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
        public double? ListPrice { get; set; }
        public double? NetPrice { get; set; }
        public string? DeliveryNumber { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
