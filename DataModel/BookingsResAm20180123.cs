using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class BookingsResAm20180123
    {
        public string? SoNumberKey { get; set; }
        public int ImportId { get; set; }
        public string? SoNumber { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerName { get; set; }
        public string? ResellerDistrict { get; set; }
        public string? ResellerCountryCode { get; set; }
        public string? ResellerPartnerLevelKey { get; set; }
        public string? SoldtoPartyGsaFlag { get; set; }
        public string? ResellerGsaFlag { get; set; }
        public string? EndCustomerGsaFlag { get; set; }
        public string? EndCustomerPartnerLevel { get; set; }
        public DateTime? TransactionCreated { get; set; }
        public string? AccountManager { get; set; }
        public string? AmCountryCode { get; set; }
        public DateTime? ImportedDate { get; set; }
        public string? ImportedStatus { get; set; }
        public long? DedupId { get; set; }
    }
}
