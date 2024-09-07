using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class StatusFbc061218
    {
        public string? ThirdPartyName { get; set; }
        public string? ApproverName { get; set; }
        public string? ApproverEmail { get; set; }
        public string? ApproverStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ProposerName { get; set; }
        public string? ProposerEmail { get; set; }
        public string? ProposerStatus { get; set; }
        public bool? IsSsoUser { get; set; }
        public string? SsoUserId { get; set; }
        public string? Theatre { get; set; }
        public string? Classification { get; set; }
        public string? Natureofbusiness { get; set; }
    }
}
