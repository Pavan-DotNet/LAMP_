using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class NsFixLp
    {
        public long? Id { get; set; }
        public string? ChannelModel { get; set; }
        public string? SerialNumber { get; set; }
        public string? ProductId { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? DiversionType { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerCountryCode { get; set; }
        public decimal? NewListPrice { get; set; }
        public decimal? NewNetPrice { get; set; }
        public string Status { get; set; } = null!;
    }
}
