using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class AccessControlVw
    {
        public int Id { get; set; }
        public string? Userid { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportLink { get; set; }
    }
}
