using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class HrExtract
    {
        public decimal? EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? EmployeeStatus { get; set; }
        public string? EmployeeType { get; set; }
        public string? EmployeeEmail { get; set; }
        public string? Region { get; set; }
        public string? Segment { get; set; }
        public string? CeoStaff { get; set; }
    }
}
