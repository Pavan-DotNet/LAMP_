using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class LampReport
    {
        public int Id { get; set; }
        public string? Report { get; set; }
        public string? ReportLink { get; set; }
        public string? ReportType { get; set; }
        public string? ReportGroup { get; set; }
        public int? DisplaySeq { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Note { get; set; }
    }
}
