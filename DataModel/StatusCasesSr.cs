using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class StatusCasesSr
    {
        public string? CaseNumber { get; set; }
        public string? ThirdPartyName { get; set; }
        public DateTime? ThirdPartyCreatedDate { get; set; }
        public string? ThirdPartyCreatedBy { get; set; }
        public string? Country { get; set; }
        public string? StateName { get; set; }
        public string? ThirdPartyType { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? DueDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string? ServiceStatus { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceNameStandardized { get; set; }
        public string? CaseCreatedBy { get; set; }
        public string? PrimaryContactPerson { get; set; }
        public string? PrimaryContactPersonEmail { get; set; }
        public string? Type { get; set; }
        public string? Natureofbusiness { get; set; }
        public string? DistiDvarReseller { get; set; }
        public string? Reason { get; set; }
        public string? Theatre { get; set; }
        public string? Classification { get; set; }
        public string? ClassificationChangeDate { get; set; }
    }
}
