using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class StatusFbc20180921
    {
        public double? ThirdPartyId { get; set; }
        public string? ThirdPartyName { get; set; }
        public string? Country { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? CaseNumber { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceNameStandardized { get; set; }
        public string? ServiceStatus { get; set; }
        public string? DueDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string? Reason { get; set; }
    }
}
