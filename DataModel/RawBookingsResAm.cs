﻿using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class RawBookingsResAm
    {
        public int ImportId { get; set; }
        public string? OrderIdKey { get; set; }
        public string? ResellerKey { get; set; }
        public string? ResellerLongText { get; set; }
        public string? ResellerBasDistrictText { get; set; }
        public string? ResellerCountryKey { get; set; }
        public string? ResellerPartnerLevelKey { get; set; }
        public string? SoldToPartyGsaFlagText { get; set; }
        public string? ResellerGsaFlagText { get; set; }
        public string? EndCustomerGsaFlagText { get; set; }
        public string? EndCustomerPartnerLevelText { get; set; }
        public string? TransactionCreatedKey { get; set; }
        public string? EmployeeResponsibleLongText { get; set; }
        public string? EmployeeResponsibleCountryKey { get; set; }
        public DateTime? ImportedDate { get; set; }
        public string? ImportedStatus { get; set; }
    }
}
