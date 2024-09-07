using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerOnboardingEffVw
    {
        public double? ThirdpartyId { get; set; }
        public string? ThirdpartyName { get; set; }
        public string? Country { get; set; }
        public string? Theatre { get; set; }
        public DateTime? ThirdpartyCreatedDate { get; set; }
        public string? NobDerived { get; set; }
        public string? TrnxName { get; set; }
        public DateTime? TrnxStartDate { get; set; }
        public DateTime? TrnxEndDate { get; set; }
        public int? DaysDiff { get; set; }
    }
}
