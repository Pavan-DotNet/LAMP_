using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class PartnerOnboardingTwbBak
    {
        public double? ThirdpartyId { get; set; }
        public string? ThirdpartyName { get; set; }
        public string? Country { get; set; }
        public string? Theatre { get; set; }
        public DateTime? ThirdpartyCreatedDate { get; set; }
        public string? ThirdpartyCreatedBy { get; set; }
        public string? ThirdpartyType { get; set; }
        public string? Natureofbusiness { get; set; }
        public string? NobDerived { get; set; }
        public string? Classification { get; set; }
        public DateTime? ClassificationDate { get; set; }
        public string? Reason { get; set; }
        public string? CaseNumber { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceNameStandardized { get; set; }
        public string? ServiceStatus { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string? CaseReason { get; set; }
        public DateTime? LatestApprovedDate { get; set; }
        public DateTime? LatestServiceCompleteDate { get; set; }
    }
}
