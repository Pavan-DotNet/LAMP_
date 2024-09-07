using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class RoleReportMapping
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? ReportId { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
