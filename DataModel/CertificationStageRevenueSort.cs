using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class CertificationStageRevenueSort
    {
        public string? WorkflowName { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeEmail { get; set; }
        public string? CertificationType { get; set; }
        public string? Quarter { get; set; }
        public string? Acceptance { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public string? DisclosureType { get; set; }
        public string? ResponseType { get; set; }
        public string? DisclosureTypeComments { get; set; }
        public string? ComplianceReview { get; set; }
        public string? ComplianceReviewComments { get; set; }
        public string? FinanceReview { get; set; }
        public string? FinanceReviewComments { get; set; }
        public string? AdditionalComments { get; set; }
        public string? Custom { get; set; }
    }
}
