using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class CertDatum
    {
        public string WorkflowName { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string EmployeeEmail { get; set; } = null!;
        public string CertificationType { get; set; } = null!;
        public string Quarter { get; set; } = null!;
        public string Acceptance { get; set; } = null!;
        public string DisclosureType { get; set; } = null!;
        public string? ResponseType { get; set; }
        public string? DisclosureTypeComments { get; set; }
        public string? ComplianceReview { get; set; }
        public string? ComplianceReviewComments { get; set; }
        public string? FinanceReview { get; set; }
        public string? FinanceReviewComments { get; set; }
        public string? AdditionalComments { get; set; }
        public DateTime? AcceptanceDate { get; set; }
        public string? CustomVal { get; set; }
    }
}
